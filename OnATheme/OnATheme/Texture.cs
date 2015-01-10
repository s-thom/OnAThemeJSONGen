using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace OnATheme
{
    public class Texture
    {
        private string _ref;
        private string _name;
        public static string TEXTURE_PATH = @"blocks/";

        /// <summary>
        /// A texture for use by a model
        /// </summary>
        /// <param name="Reference"></param>
        /// <param name="Name"></param>
        public Texture(string Reference, string Name)
        {
            _ref = Reference;
            _name = Name;
        }

        /// <summary>
        /// String model is refered to as
        /// e.g. 'cross' in '"cross":"blocks/flower_allium"'
        /// </summary>
        public string Reference { get { return _ref; } }
        /// <summary>
        /// Name of the texture 
        /// </summary>
        public string Name { get { return _name; } }

        /// <summary>
        /// Write the property name and value for this texture
        /// </summary>
        /// <param name="w"></param>
        public void WriteTextureJSON(JsonWriter w)
        {
            w.WritePropertyName(_ref);
            w.WriteValue(TEXTURE_PATH + _name);
        }
        /// <summary>
        /// Texture name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _ref + ": " + _name;
        }
    }
}
