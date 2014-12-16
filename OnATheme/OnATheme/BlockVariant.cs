﻿using System;
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
        public List<Model> Models = new List<Model>();
        private string _name = "normal"; // e.g. "facing=north"

        /// <summary>
        /// A particular variant of a block
        /// e.g. for a door, "half=upper"
        /// </summary>
        /// <param name="Block"></param>
        /// <param name="Name"></param>
        /// <param name="Models"></param>
        public BlockVariant(string Name, string ParentModel, string BlockName, List<Texture> Textures, int NumVariants, bool CreateModelJson, bool[] XRotations, bool[] YRotations)
        {
            if (Name != "")
                _name = Name;

            Models.Add(new Model(BlockName, ParentModel, Textures, CreateModelJson, XRotations, YRotations));

            for (int i = 1; i <= NumVariants; i++)
            {
                List<Texture> modelTextures = new List<Texture>();
                // Add new textures, adding the variant number to the end
                foreach (Texture t in Textures)
                {
                    modelTextures.Add(new Texture(t.Reference, t.Name + "_" + i.ToString()));
                }

                Models.Add(new Model(BlockName + "_" + i.ToString(), BlockName, modelTextures, CreateModelJson, XRotations, YRotations));
            }
        }

        /// <summary>
        /// Write text to be use in the blockstates file
        /// </summary>
        /// <param name="w"></param>
        public void WriteBlockVariant(JsonWriter w)
        {
            w.WritePropertyName(_name);
            w.WriteStartArray();
            foreach (Model m in Models)
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