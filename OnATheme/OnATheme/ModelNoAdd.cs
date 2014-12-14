﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    class ModelNoAdd : Model
    {
        /// <summary>
        /// Will generate no model file, but still populate the blockstates
        /// </summary>
        /// <param name="Block"></param>
        /// <param name="VariantNumber"></param>
        public ModelNoAdd(string Block, int VariantNumber)
            : base(Block, "", "", VariantNumber)
        { }
        /// <summary>
        /// Will not do anything.
        /// </summary>
        public override void CreateModel()
        {
            Console.WriteLine("Not generating model, as requested");
        }
    }
}