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
        protected bool _createModelJson;
        protected static string MODEL_PATH = @"block/";

        /// <summary>
        /// Model for the game to use
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Parent"></param>
        /// <param name="Textures"></param>
        /// <param name="Weight"></param>
        public Model(string Name, string Parent, List<Texture> Textures, bool CreateJson, bool[] XRotations, bool[] YRotations)
        {
            _name = Name;
            _parent = Parent;
            _textures = Textures;
            _createModelJson = CreateJson;

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
        /// Whether or not to create the individual model file
        /// Set to false if you're using your own models
        /// </summary>
        public bool CreateJson { get { return _createModelJson; } set { _createModelJson = value; } }

        /// <summary>
        /// Create the model file for the variant
        /// </summary>
        public virtual void WriteModel()
        {
            if (_parent != "" && _createModelJson)
            {
                JsonWriter w = new JsonTextWriter(File.CreateText(@"OaT/assets/minecraft/models/block/" + _name + ".json"));
                w.Formatting = Formatting.Indented;

                w.WriteStartObject();
                w.WritePropertyName("parent");
                w.WriteValue(MODEL_PATH + _parent);
                w.WritePropertyName("textures");

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
                            w.WriteStartObject();

                            w.WritePropertyName("model");
                            w.WriteValue(_name);

                            if (_weight != 1)
                            {
                                w.WritePropertyName("weight");
                                w.WriteValue(_weight);
                            }
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
