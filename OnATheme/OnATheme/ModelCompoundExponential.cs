using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    public class ModelCompoundExponential : ModelCompound
    {
        List<TextureGroup> _textureGroups = new List<TextureGroup>();

        /// <summary>
        /// A model with permutations
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Parent"></param>
        /// <param name="TextureGroups"></param>
        /// <param name="XRotation"></param>
        /// <param name="YRotation"></param>
        public ModelCompoundExponential(string Name, string Parent, List<TextureGroup> TextureGroups, bool[] XRotation, bool[] YRotation)
            :base(Name,Parent,XRotation,YRotation)
        {
            _textureGroups = TextureGroups;

            // Calculate the number of models
            _numModels = 1;
            foreach (TextureGroup tg in _textureGroups)
                _numModels *= (int)Math.Pow(tg.Textures.Count, tg.Faces.Count);
        }

        /// <summary>
        /// Write the model files for the model
        /// </summary>
        public override void WriteModel()
        {
            int _modelNo = 0, _groupNo = 0;
            List<Texture> _modelTextures = new List<Texture>();

            // Add textures
            
            WriteModelRecur(_modelTextures, 0, ref _modelNo, _groupNo);

            // Force the garbage collection.
            // Since there could be a lot of objects getting destroyed,
            // I thought I'd better do this.
            GC.Collect();
        }
        /// <summary>
        /// Create the model files for all of the possible combinations
        /// </summary>
        /// <param name="ModelTextures"></param>
        /// <param name="UnusedSides"></param>
        /// <param name="modelNo"></param>
        private void WriteModelRecur(List<Texture> ModelTextures, int Face, ref int modelNo, int groupNo)
        {
            // Test to see if we've gone too deep
            if (groupNo < _textureGroups.Count)
            {
                if (Face < _textureGroups[groupNo].Faces.Count)
                {
                    // Fore every texture, go deeper
                    for (int i = 0; i < _textureGroups[groupNo].Textures.Count; i++)
                    {
                        ModelTextures.Add(new Texture(_textureGroups[groupNo].Faces[Face], _textureGroups[groupNo].Textures[i]));
                        // Down the rabbit hole
                        if (Face >= _textureGroups[groupNo].Faces.Count - 1)
                            WriteModelRecur(ModelTextures, 0, ref modelNo, groupNo + 1);
                        else
                            WriteModelRecur(ModelTextures, Face + 1, ref modelNo, groupNo);
                        // Remove the texture just created
                        ModelTextures.RemoveAt(ModelTextures.Count - 1);
                    }
                }
            }
            else
            {
                JsonWriter w;
                // Create the writer
                if (modelNo == 0 && _parent != _name)
                    w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/models/block/" + _name + ".json"));
                else
                    w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/models/block/" + _name + "_" + modelNo.ToString() + ".json"));

                w.Formatting = Formatting.Indented;

                w.WriteStartObject();
                w.WritePropertyName("parent");
                w.WriteValue(MODEL_PATH + _parent);
                w.WritePropertyName("textures");
                // Write each texture
                w.WriteStartObject();
                foreach (Texture t in ModelTextures)
                    t.WriteTextureJSON(w);
                w.WriteEndObject();

                w.WriteEndObject();

                w.Close();
                // Go to the next model number, and get back into it
                modelNo++;
                groupNo--;
            }
        }
        public override List<Model> ConvertToIndividualModels()
        {
            int _modelNo = 0, _groupNo = 0;
            List<Texture> _modelTextures = new List<Texture>();
            List<Model> models = new List<Model>();

            ConvertModelRecur(_modelTextures, 0, ref _modelNo, _groupNo, models);

            return models;
        }
        /// <summary>
        /// Create Model objects for every possible combination
        /// </summary>
        /// <param name="ModelTextures"></param>
        /// <param name="Face"></param>
        /// <param name="modelNo"></param>
        /// <param name="groupNo"></param>
        /// <param name="Models"></param>
        private void ConvertModelRecur(List<Texture> ModelTextures, int Face, ref int modelNo, int groupNo, List<Model> Models)
        {
            // Have we gone too deep?
            if (groupNo < _textureGroups.Count)
            {
                if (Face < _textureGroups[groupNo].Faces.Count)
                {
                    // For every texture
                    for (int i = 0; i < _textureGroups[groupNo].Textures.Count; i++)
                    {
                        ModelTextures.Add(new Texture(_textureGroups[groupNo].Faces[Face], _textureGroups[groupNo].Textures[i]));
                        if (Face >= _textureGroups[groupNo].Faces.Count - 1)
                            ConvertModelRecur(ModelTextures, 0, ref modelNo, groupNo + 1, Models);
                        else
                            ConvertModelRecur(ModelTextures, Face + 1, ref modelNo, groupNo, Models);
                        ModelTextures.RemoveAt(ModelTextures.Count - 1);
                    }
                }
            }
            else
            {
                // Create a new list based on the current one.
                // Can't use ModelTexures, or it will use the same reference.
                List<Texture> t = new List<Texture>(ModelTextures);

                if (modelNo == 0 && _parent != _name)
                    Models.Add(new ModelIndividual(_name, _parent, t, _xRot, _yRot)); 
                else
                    Models.Add(new ModelIndividual(_name + "_" + modelNo.ToString(), _parent, t, _xRot, _yRot));

                modelNo++;
            }
        }
    }
}
