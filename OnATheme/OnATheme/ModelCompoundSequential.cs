using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    class ModelCompoundSequential : ModelCompound
    {
        List<Texture> _texturesVariable = new List<Texture>();

        /// <summary>
        /// A model wchich changes textures based on the internal number
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Parent"></param>
        /// <param name="ConstantTextures"></param>
        /// <param name="VariableTextures"></param>
        /// <param name="XRotation"></param>
        /// <param name="YRotation"></param>
        public ModelCompoundSequential(string Name, string Parent, List<Texture> ConstantTextures, List<Texture> VariableTextures, int NumVariations, bool[] XRotation, bool[] YRotation)
            : base(Name, Parent, XRotation, YRotation)
        {
            _textures = ConstantTextures;
            _texturesVariable = VariableTextures;
            // +1 to include "0th" model 
            _numModels = NumVariations + 1;
        }
        public override void WriteModel()
        {
            for (int i = 0; i < _numModels; i++)
            {
                List<Texture> t;
                if (_textures == null)
                    t = new List<Texture>();
                else
                    t = new List<Texture>(_textures);

                for (int j = 0; j < _texturesVariable.Count; j++)
                {
                    if (i == 0)
                        t.Add(new Texture(_texturesVariable[j].Reference, _texturesVariable[j].Name));
                    else
                        t.Add(new Texture(_texturesVariable[j].Reference, _texturesVariable[j].Name + "_" + i.ToString()));
                }
                if (!(i == 0 && _parent == _name))
                {
                    JsonWriter w;
                    // Write the model
                    if (i == 0)
                        w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/models/block/" + _name + ".json"));
                    else
                        w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/models/block/" + _name + "_" + i.ToString() + ".json"));

                    w.Formatting = Formatting.Indented;

                    w.WriteStartObject();
                    w.WritePropertyName("parent");
                    w.WriteValue(MODEL_PATH + _parent);
                    w.WritePropertyName("textures");

                    w.WriteStartObject();
                    foreach (Texture texture in t)
                        texture.WriteTextureJSON(w);
                    w.WriteEndObject();

                    w.WriteEndObject();

                    w.Close();
                }
            }
        }
        /// <summary>
        /// Convert sequential model to a list of models
        /// </summary>
        /// <returns></returns>
        public override List<Model> ConvertToIndividualModels()
        {
            List<Model> models = new List<Model>();
            for (int i = 0; i < _numModels; i++)
            {
                List<Texture> t;
                if (_textures == null)
                    t = new List<Texture>();
                else
                    t = new List<Texture>(_textures);

                for (int j = 0; j < _texturesVariable.Count; j++)
                {
                    if (i == 0)
                        t.Add(new Texture(_texturesVariable[j].Reference, _texturesVariable[j].Name));
                    else
                        t.Add(new Texture(_texturesVariable[j].Reference, _texturesVariable[j].Name + "_" + i.ToString()));
                }
                if (_parent != _name)
                {
                    if (i == 0)
                        models.Add(new Model(_name, _parent, t, _xRot, _yRot));
                    else
                        models.Add(new Model(_name + "_" + i.ToString(), _parent, t, _xRot, _yRot));
                    Console.WriteLine("break");
                }
            }
            return models;
        }
    }
}
