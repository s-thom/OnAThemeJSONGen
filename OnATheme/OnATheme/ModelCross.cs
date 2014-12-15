using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    class ModelCross : ModelOLD
    {
        /// <summary>
        /// Model in the shape of a cross
        /// </summary>
        /// <param name="Parent"></param>
        /// <param name="Texture"></param>
        /// <param name="VariantNumber"></param>
        public ModelCross(string Block, string Parent, string Texture, int VariantNumber)
            : base(Block, Parent, Texture, VariantNumber)
        { }
        public override void CreateTextureJSON(JsonWriter w)
        {
            w.WriteStartObject();
            w.WritePropertyName("cross");
            w.WriteValue(TEXTURE_PATH + _textureName + "_" + _variantNo.ToString());
            w.WriteEndObject();
        }
    }
}
