using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    public class Model
    {
        protected List<Texture> _textures;
        protected string _name;
        protected string _parent;
        protected int _weight = 1; // Default, just in case
        static string MODEL_PATH = @"block/";

        /// <summary>
        /// Model for the game to use
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Parent"></param>
        /// <param name="Textures"></param>
        /// <param name="Weight"></param>
        public Model(string Name, string Parent, List<Texture> Textures)
        {
            _name = Name;
            _parent = Parent;
            _textures = Textures;
        }

        /// <summary>
        /// Model weight. Must be greater than 0
        /// </summary>
        public int Weight { get { return _weight; } set { if (value > 0) _weight = value; } }

        /// <summary>
        /// Create the model file for the variant
        /// </summary>
        public void WriteModel()
        {
            JsonWriter w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/models/block/" + _name + ".json"));
            w.Formatting = Formatting.Indented;

            w.WriteStartObject();
            w.WritePropertyName("parent");
            w.WriteValue(MODEL_PATH + _parent);
            w.WritePropertyName("textures");

            w.WriteStartObject();
            foreach (Texture t in _textures)
                t.WriteTextureJSON(w);
            w.WriteEndObject();

            w.WriteEndObject();

            w.Close();
        }
        /// <summary>
        /// Write the info used in the blockstates file
        /// </summary>
        /// <param name="w"></param>
        public void WriteBlockstate(JsonWriter w)
        {
            w.WriteStartObject();

            w.WritePropertyName("model");
            w.WriteValue(_name);
            w.WritePropertyName("weight");
            w.WriteValue(_weight);

            w.WriteEndObject();
        }
        /// <summary>
        /// Name of the Model
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _name;
        }
    }
}
