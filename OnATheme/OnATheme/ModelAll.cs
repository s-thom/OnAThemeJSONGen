using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    class ModelAll : Model
    {
        /// <summary>
        /// Generic block. All 6 sides one texture
        /// </summary>
        /// <param name="Block"></param>
        /// <param name="Parent"></param>
        /// <param name="Texture"></param>
        /// <param name="VariantNumber"></param>
        public ModelAll(string Block, string Parent, string Texture, int VariantNumber)
            : base(Block, Parent, Texture, VariantNumber)
        { }
        public override void CreateModel()
        {
            JsonWriter w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/models/block/" + ModelName + ".json"));
            w.Formatting = Formatting.Indented;

            w.WriteStartObject();
            w.WritePropertyName("parent");
            w.WriteValue(MODEL_PATH + _parent);
            w.WritePropertyName("textures");
            w.WriteStartObject();
            w.WritePropertyName("all");
            w.WriteValue(TEXTURE_PATH + _textureName + "_" + _variantNo.ToString());
            w.WriteEndObject();
            w.WriteEndObject();

            w.Close();
        }
    }
}
