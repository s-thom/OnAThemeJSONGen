using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    class ModelAll : ModelOLD
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
        public override void CreateTextureJSON(JsonWriter w)
        {
            w.WriteStartObject();
            w.WritePropertyName("all");
            w.WriteValue(TEXTURE_PATH + _textureName + "_" + _variantNo.ToString());
            w.WriteEndObject();
        }
    }
}
