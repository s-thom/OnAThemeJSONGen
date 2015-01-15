using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace OnATheme
{
    public abstract class ModelCompound : Model
    {
        /// <summary>
        /// A model that holds information for the creation of several models
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Parent"></param>
        /// <param name="XRotations"></param>
        /// <param name="YRotations"></param>
        public ModelCompound(string Name, string Parent, bool[] XRotations, bool[] YRotations)
            : base(Name, Parent, XRotations, YRotations)
        { }
        /// <summary>
        /// Convert the compound model into individual models
        /// </summary>
        /// <returns></returns>
        public abstract List<Model> ConvertToIndividualModels();
    }
}
