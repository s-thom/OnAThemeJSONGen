using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    public class BlockVariant
    {
        /// <summary>
        /// Models this attribute uses
        /// </summary>
        public List<ModelExpon> Models = new List<ModelExpon>();
        private string _name = "normal"; // e.g. "facing=north"

        /// <summary>
        /// A particular variant of a block
        /// e.g. for a door, "half=upper"
        /// </summary>
        /// <param name="Block"></param>
        /// <param name="Name"></param>
        /// <param name="Models"></param>
        public BlockVariant(string Name, ModelExpon BlockModel)
        {
            if (Name != "")
                _name = Name;

            Models.Add(BlockModel);
        }

        /// <summary>
        /// Write text to be use in the blockstates file
        /// </summary>
        /// <param name="w"></param>
        public void WriteBlockVariant(JsonWriter w)
        {
            w.WritePropertyName(_name);
            w.WriteStartArray();
            foreach (ModelExpon m in Models)
            {
                m.WriteBlockstate(w);
            }
            w.WriteEndArray();
        }
        /// <summary>
        /// Name of the variant
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _name;
        }
    }
}
