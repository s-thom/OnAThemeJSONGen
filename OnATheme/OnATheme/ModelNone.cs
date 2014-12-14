using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    class ModelNone : Model
    {
        /// <summary>
        /// Displayed model will be invisible
        /// </summary>
        /// <param name="Block"></param>
        /// <param name="Texture"></param>
        /// <param name="VariantNumber"></param>
        public ModelNone(string Block, string Texture, int VariantNumber)
            : base(Block, "none", Texture, VariantNumber)
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
            w.WritePropertyName("particle");
            w.WriteValue(TEXTURE_PATH + _textureName);
            w.WriteEndObject();
            w.WriteEndObject();

            w.Close();
        }
    }
}
