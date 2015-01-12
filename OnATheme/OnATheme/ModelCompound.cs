using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnATheme
{
    public abstract class ModelCompound : Model
    {
        public ModelCompound(string Name, string Parent, bool[] XRotations, bool[] YRotations)
            : base(Name, Parent, null, XRotations, YRotations)
        { }

        /// <summary>
        /// Convert the compound model into individual models
        /// </summary>
        /// <returns></returns>
        public abstract List<Model> ConvertToIndividualModels();
    }
}
