using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnATheme
{
    public class TextureGroup
    {
        private List<string> _faces = new List<string>();
        private List<string> _textures = new List<string>();

        /// <summary>
        /// Faces that can have any one of the specified textures
        /// </summary>
        /// <param name="Faces"></param>
        /// <param name="Textures"></param>
        public TextureGroup(List<string> Faces, List<string> Textures)
        {
            _faces = Faces;
            _textures = Textures;
        }

        /// <summary>
        /// Faces this texture group can apply to
        /// </summary>
        public List<string> Faces { get { return _faces; } }
        /// <summary>
        /// Textures for this group to use
        /// </summary>
        public List<string> Textures { get { return _textures; } }

        public override string ToString()
        {
            try
            {
                string name = "";

                name += _faces[0];
                if (_faces.Count > 1)
                    name += ", +" + (_faces.Count - 1).ToString();
                name += ": ";
                name += _textures[0];
                if (_textures.Count > 1)
                    name += ", +" + (_textures.Count - 1).ToString();

                return name;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return "INVALID: " + ex.Message;
            }
        }
    }
}
