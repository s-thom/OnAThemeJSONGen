using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    public class Block
    {
        public List<BlockVariant> BlockVariants = new List<BlockVariant>();
        private string _name;

        public Block(string Name, List<BlockVariant> Variants)
        {
            _name = Name;
            BlockVariants = Variants;
        }
        /// <summary>
        /// Create all JSON files
        /// </summary>
        public void CreateJSON()
        {
            // Create the model files first
            foreach (BlockVariant b in BlockVariants)
                foreach (Model m in b.Models)
                    m.WriteModel();

            // Create writer and set style
            JsonWriter w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/blockstates/" + _name + ".json"));
            w.Formatting = Formatting.Indented;

            w.WriteStartObject();
            w.WritePropertyName("variants");
            w.WriteStartObject();

            foreach (BlockVariant b in BlockVariants)
            {
                b.WriteBlockVariant(w);
            }

            w.WriteEndObject();
            w.WriteEndObject();

            w.Close();
        }
        /// <summary>
        /// Name of the block
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _name;
        }
    }
}
