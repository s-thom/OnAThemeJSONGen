using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    class ModelIndividual : Model
    {
        protected List<Texture> _textures;
        
        /// <summary>
        /// An individual model
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Parent"></param>
        /// <param name="Textures"></param>
        /// <param name="XRotations"></param>
        /// <param name="YRotations"></param>
        public ModelIndividual(string Name, string Parent, List<Texture> Textures, bool[] XRotations, bool[] YRotations)
            : base(Name, Parent, XRotations, YRotations)
        {
            _textures = Textures;
        }


        /// <summary>
        /// Model weight. Must be greater than 0
        /// </summary>
        public int Weight { get { return _weight; } set { if (value > 0) _weight = value; } }
        
        /// <summary>
        /// Create the model file for the variant
        /// </summary>
        public override void WriteModel()
        {
            if (_parent != "")
            {
                // Create JSON writer
                JsonWriter w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/models/block/" + _name + ".json"));
                w.Formatting = Formatting.Indented;

                // Write model to the Minecraft JSON specification
                w.WriteStartObject();
                w.WritePropertyName("parent");
                w.WriteValue(MODEL_PATH + _parent);
                w.WritePropertyName("textures");

                // Write each texture
                w.WriteStartObject();
                foreach (Texture t in _textures)
                    t.WriteTextureJSON(w);
                w.WriteEndObject();

                w.WriteEndObject();

                w.Close();
            }
        }
    }
}
