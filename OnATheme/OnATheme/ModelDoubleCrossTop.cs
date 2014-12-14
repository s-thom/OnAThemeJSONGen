using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    class ModelDoubleCrossTop : ModelNone
    {
        /// <summary>
        /// "None" by another name.
        /// Displayed block will be invisible. Particles still show
        /// </summary>
        /// <param name="Block"></param>
        /// <param name="Texture"></param>
        /// <param name="VariantNumber"></param>
        public ModelDoubleCrossTop(string Block, string Texture, int VariantNumber)
            : base(Block, Texture, VariantNumber)
        { }
        public override string ModelName { get { return _block + "_top"; } }
        public override void CreateTextureJSON(JsonWriter w)
        {
            w.WriteStartObject();
            w.WritePropertyName("particle");
            w.WriteValue(TEXTURE_PATH + _textureName);
            w.WriteEndObject();
        }
    }
}
