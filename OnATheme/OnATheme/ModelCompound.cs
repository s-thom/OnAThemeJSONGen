using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

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

        public override void WriteBlockstate(JsonWriter w)
        {
            // The loops and ifs are used to decide whether or not to write this variant as rotated.
            // Currently, thre is no way to specify different weights for each rotation (apart from manual editing)
            // To do so would be a pain to do. Hence, I'm not doing it. (right now, that is)
            for (int i = 0; i < 4; i++)
                if (_xRot[i])
                    for (int j = 0; j < 4; j++)
                        if (_yRot[j])
                        {
                            for (int k = 0; k < _numModels; k++)
                            {
                                w.WriteStartObject();

                                w.WritePropertyName("model");
                                if (k == 0 && _parent != _name)
                                    w.WriteValue(_name);
                                else
                                    w.WriteValue(_name + "_" + k.ToString());

                                if (i != 0) // Do not need to write if it's 0.
                                {
                                    w.WritePropertyName("x");
                                    w.WriteValue(i * 90);
                                }
                                if (j != 0) // Same as above.
                                {
                                    w.WritePropertyName("y");
                                    w.WriteValue(j * 90);
                                }
                                if (_uvLock)
                                {
                                    w.WritePropertyName("uvlock");
                                    w.WriteValue(true); // If this piece of code is executed, then it must be true.
                                }

                                w.WriteEndObject();
                            }
                        }
        }
    }
}
