using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OnATheme
{
    public class Model
    {
        protected List<Texture> _textures;
        protected string _name;
        protected string _parent;
        protected int _weight = 1; // Default, just in case
        protected bool[] _xRot = new bool[4] { true, false, false, false };
        protected bool[] _yRot = new bool[4] { true, false, false, false };
        protected bool _uvLock = false;
        protected int _numModels = 1;
        protected static string MODEL_PATH = @"block/";

        /// <summary>
        /// Model for the game to use
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Parent"></param>
        /// <param name="Textures"></param>
        /// <param name="Weight"></param>
        public Model(string Name, string Parent, List<Texture> Textures, bool[] XRotations, bool[] YRotations)
        {
            _name = Name;
            _parent = Parent;
            _textures = Textures;

            // Set rotations
            if (XRotations.Length == 4)
                _xRot = XRotations;
            if (YRotations.Length == 4)
                _yRot = YRotations;
        }

        /// <summary>
        /// Model weight. Must be greater than 0
        /// </summary>
        public int Weight { get { return _weight; } set { if (value > 0) _weight = value; } }
        /// <summary>
        /// Name of the model
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }
        /// <summary>
        /// Rotate the texture with the block if false (default)
        /// </summary>
        public bool UVLock { get { return _uvLock; } set { _uvLock = value; } }
        /// <summary>
        /// Rotations around the X axis for this block
        /// [0] = 0, [1] = 90, [2] = 180, [3] = 270
        /// </summary>
        public bool[] XRotation { get { return _xRot; } set { if (value.Length == 4) _xRot = value; } }
        /// <summary>
        /// Rotations around the Y axis for this block
        /// [0] = 0, [1] = 90, [2] = 180, [3] = 270
        /// </summary>
        public bool[] YRotation { get { return _yRot; } set { if (value.Length == 4) _yRot = value; } }
        /// <summary>
        /// Number of models this model hold information for
        /// Mostly used for compounds
        /// </summary>
        public int NumModels { get { return _numModels; } }

        /// <summary>
        /// Create the model file for the variant
        /// </summary>
        public virtual void WriteModel()
        {
            if (_parent != "")
            {
                // Create JSON writer
                JsonWriter w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/models/block/" + _name + ".json"));
                w.Formatting = Formatting.Indented;

                // Write model to the Minecraft JSON specification
                w.WriteStartObject();
                w.WritePropertyName("parent");
                w.WriteValue(MODEL_PATH + _parent);
                w.WritePropertyName("textures");

                // Write each texture
                w.WriteStartObject();
                foreach (Texture t in _textures)
                    t.WriteTextureJSON(w);
                w.WriteEndObject();

                w.WriteEndObject();

                w.Close();
            }
        }
        /// <summary>
        /// Write the info used in the blockstates file
        /// </summary>
        /// <param name="w"></param>
        public virtual void WriteBlockstate(JsonWriter w)
        {
            // The loops and ifs are usd to decide whether or not to write this variant as rotated.
            // Currently, thre is no way to specify different weights for each rotation (apart from manual editing)
            for (int i = 0; i < 4; i++)
                if (_xRot[i])
                    for (int j = 0; j < 4; j++)
                        if (_yRot[j])
                        {
                            // For each model
                            // Only one, if it's a normal model, potentially more if it's a compound
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
        /// <summary>
        /// Name of the Model
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _name;
        }
    }
}