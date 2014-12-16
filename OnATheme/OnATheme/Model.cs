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
        protected bool _createModelJson;
        static string MODEL_PATH = @"block/";

        /// <summary>
        /// Model for the game to use
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Parent"></param>
        /// <param name="Textures"></param>
        /// <param name="Weight"></param>
        public Model(string Name, string Parent, List<Texture> Textures, bool CreateJson)
        {
            _name = Name;
            _parent = Parent;
            _textures = Textures;
            _createModelJson = CreateJson;
        }

        /// <summary>
        /// Model weight. Must be greater than 0
        /// </summary>
        public int Weight { get { return _weight; } set { if (value > 0) _weight = value; } }
        /// <summary>
        /// Name of the model
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }
        /// <summary>
        /// Whether or not to create the individual model file
        /// Set to false if you're using your own models
        /// </summary>
        public bool CreateJson { get { return _createModelJson; } set { _createModelJson = value; } }

        /// <summary>
        /// Create the model file for the variant
        /// </summary>
        public void WriteModel()
        {
            if (_parent != "" && _createModelJson)
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
