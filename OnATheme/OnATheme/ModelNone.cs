using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    class ModelNone : ModelOLD
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
        public override void CreateTextureJSON(JsonWriter w)
        {
            w.WriteStartObject();
            w.WritePropertyName("particle");
            w.WriteValue(TEXTURE_PATH + _textureName);
            w.WriteEndObject();
        }
    }
}
