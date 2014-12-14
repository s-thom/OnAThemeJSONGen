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
        protected string _blockName;
        protected string _type;
        /// <summary>
        /// List of models this block uses
        /// </summary>
        public List<Model> Models = new List<Model>();
        /// <summary>
        /// Create the models for a particular block.
        /// This turns into the blockstates file.
        /// </summary>
        /// <param name="ModelName"></param>
        /// <param name="NumVariants"></param>
        /// <param name="Texture"></param>
        public Block(string BlockName, int NumVariants, string Texture, string Type)
        {
            _blockName = BlockName;
            _type = Type;
            if (Texture == "")
                Texture = _blockName;
            // Special cases, includes no number.
            switch (_type)
            {
                case "Full Block":
                    Models.Add(new ModelAll(_blockName, "cube_all", Texture, 0));
                    break;
                case "Cross":
                    Models.Add(new ModelCross(_blockName, "cross", Texture, 0));
                    break;
                case "Double Cross":
                    Models.Add(new ModelDoubleCross(_blockName, "double_cross", Texture, 0));
                    Models.Add(new ModelDoubleCrossTop(_blockName, Texture, 0));
                    break;
                case "Double Cross Tint":
                    Models.Add(new ModelDoubleCross(_blockName, "double_cross_tint", Texture, 0));
                    Models.Add(new ModelDoubleCrossTop(_blockName, Texture, 0));
                    break;
                case "Don't Create Models":
                    Models.Add(new ModelNoAdd(_blockName, 0));
                    break;
            }
            // Create variants than inherit from the original
            for (int i = 1; i <= NumVariants; i++)
            {
                switch (_type)
                {
                    case "Full Block":
                        Models.Add(new ModelAll(_blockName, _blockName, Texture, i));
                        break;
                    case "Cross":
                        Models.Add(new ModelCross(_blockName, _blockName, Texture, i));
                        break;
                    case "Double Cross":
                        Models.Add(new ModelDoubleCross(_blockName, _blockName, Texture, i));
                        break;
                    case "Double Cross Tint":
                        Models.Add(new ModelDoubleCrossTint(_blockName, _blockName, Texture, i));
                        break;
                    case "Don't Create Models":
                        Models.Add(new ModelNoAdd(_blockName, i));
                        break;
                    default:
                        Console.WriteLine("Unknown model type, ignoring.");
                        break;
                }
            }
        }
        /// <summary>
        /// Name of the block
        /// </summary>
        public string BlockName { get { return _blockName; } }
        /// <summary>
        /// Create the moels used by the blockstate file
        /// </summary>
        public void CreateBlockModels()
        {
            foreach (Model m in Models)
            {
                m.CreateModel();
            }
        }
        /// <summary>
        /// Create the blockstate file for this block
        /// </summary>
        public void CreateBlockstates()
        {
            // Create writer and set style
            JsonWriter w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/blockstates/" + _blockName + ".json"));
            w.Formatting = Formatting.Indented;

            w.WriteStartObject();
            w.WritePropertyName("variants");
            w.WriteStartObject();
            // Things that are two blocks tall are special.
            // Until I set a smarter attribute system, this is how you have to do this.
            if (_type == "Double Cross" || _type == "Double Cross Tint")
            {
                w.WritePropertyName("half=upper");
                w.WriteStartObject();
                w.WritePropertyName("model");
                w.WriteValue(_blockName + "_top");
                w.WriteEndObject();
                w.WritePropertyName("half=lower");
                w.WriteStartArray();

                BlockStatesLoop(w);

                w.WriteEndArray();
            }
            else
            {
                w.WritePropertyName("normal");
                w.WriteStartArray();
                w.WriteStartObject();
                w.WriteEndObject();

                BlockStatesLoop(w);

                w.WriteEndArray();
            }
            w.WriteEndObject();
            w.WriteEndObject();

            w.Close();
        }
        /// <summary>
        /// Go through each model and add it to the blockstates
        /// </summary>
        /// <param name="w"></param>
        private void BlockStatesLoop(JsonWriter w)
        {
            // I broke this particular statement out as it was getting repeated a few times
            foreach (Model m in Models)
            {
                if (!(m is ModelNone))
                {
                    w.WriteStartObject();
                    w.WritePropertyName("model");
                    w.WriteValue(m.ModelName);
                    w.WritePropertyName("weight");
                    w.WriteValue(m.Weight);
                    w.WriteEndObject();
                }
            }
        }
        /// <summary>
        /// Return the name of the block
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return BlockName;
        }
    }
}
