using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    public abstract class Model
    {
        protected string _parent; // Parent model ("allium")
        protected string _textureName; // for "flower_allium_1", this is "flower_allium"
        protected string _block; // Block this model belongs to
        protected int _variantNo; // i.e. "1"
        protected int _weight = 1;

        protected static string MODEL_PATH = @"block/";
        protected static string TEXTURE_PATH = @"blocks/";

        /// <summary>
        /// An individual model for a block.
        /// </summary>
        /// <param name="Parent"></param>
        /// <param name="Texture"></param>
        /// <param name="VariantNumber"></param>
        public Model(string Block, string Parent, string Texture, int VariantNumber)
        {
            _parent = Parent;
            _textureName = Texture;
            _block = Block;
            _variantNo = VariantNumber;
        }
        /// <summary>
        /// The name of the model
        /// </summary>
        public virtual string ModelName 
        { 
            get 
            {
                if (_variantNo == 0)
                    return _block;
                else
                    return _block + "_" + _variantNo.ToString();
            } 
        }
        public string TextureName { get { return _textureName; } }
        /// <summary>
        /// <summary>
        /// Weighting of the model
        /// </summary>
        public int Weight { get { return _weight; } set { _weight = value; } }
        /// <summary>
        /// Create the model file for the variant
        /// </summary>
        public void CreateModel()
        {
            if (!(this is ModelNoAdd)) // The "NoAdd" model doesn't create a file.
            {
                JsonWriter w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/models/block/" + ModelName + ".json"));
                w.Formatting = Formatting.Indented;

                w.WriteStartObject();
                w.WritePropertyName("parent");
                w.WriteValue(MODEL_PATH + _parent);
                w.WritePropertyName("textures");

                CreateTextureJSON(w);

                w.WriteEndObject();

                w.Close();
            }
        }

        public abstract void CreateTextureJSON(JsonWriter w);

        public override string ToString()
        {
            return ModelName;
        }
    }
}
