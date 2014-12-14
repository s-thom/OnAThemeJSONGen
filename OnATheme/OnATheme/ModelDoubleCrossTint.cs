using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    class ModelDoubleCrossTint : ModelDoubleCross
    {
        /// <summary>
        /// A two-block high "cross", but changes based on biome
        /// </summary>
        /// <param name="Block"></param>
        /// <param name="Parent"></param>
        /// <param name="Texture"></param>
        /// <param name="VariantNumber"></param>
        public ModelDoubleCrossTint(string Block, string Parent, string Texture, int VariantNumber)
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
            w.WritePropertyName("top");
            if (_variantNo == 0)
                w.WriteValue(TEXTURE_PATH + _textureName + "_top");
            else
                w.WriteValue(TEXTURE_PATH + _textureName + "_top_" + _variantNo.ToString());
            w.WritePropertyName("bottom");
            if (_variantNo == 0)
                w.WriteValue(TEXTURE_PATH + _textureName + "_bottom");
            else
                w.WriteValue(TEXTURE_PATH + _textureName + "_bottom_" + _variantNo.ToString());
            w.WriteEndObject();
            w.WriteEndObject();

            w.Close();
        }
    }
}
