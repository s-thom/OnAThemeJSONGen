using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    class Block
    {
        public List<Attribute> Attributes = new List<Attribute>();
        private string _name;

        public Block(string Name, List<Attribute> Variants)
        {
            _name = Name;
            Attributes = Variants;
        }
        /// <summary>
        /// Create all JSON files
        /// </summary>
        public void CreateJSON()
        {
            // Create the model files first
            foreach (Attribute a in Attributes)
                foreach (Model m in a.Models)
                    m.WriteModel();

            // Create writer and set style
            JsonWriter w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/blockstates/" + _name + ".json"));
            w.Formatting = Formatting.Indented;

            w.WriteStartObject();
            w.WritePropertyName("variants");
            w.WriteStartObject();

            foreach (Attribute a in Attributes)
            {
                a.WriteAttribute(w);
            }

            w.WriteEndObject();
            w.WriteEndObject();

            w.Close();
        }
    }
}
