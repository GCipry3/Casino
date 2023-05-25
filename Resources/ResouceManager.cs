using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Resources
{
   public static class ResourceManager
    {
        public static Bitmap GetImage(string resourceName)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Stream imageStream = currentAssembly.GetManifestResourceStream(resourceName);
            return new Bitmap(imageStream);
        }

        public static Stream GetSoundStream(string resourceName)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Stream soundStream = currentAssembly.GetManifestResourceStream(resourceName);
            return soundStream;
        }
    }
}
