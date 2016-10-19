using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    /// <summary>
    ///     Encapsulates extension methods for the <see cref="Assembly" />.
    /// </summary>
    public static class AssemblyExtensions
    {
        /// <summary>
        /// Gets the manifest resource's text.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <param name="name">The manifest resource's name.</param>
        /// <returns>Returns the content of the manifest resource as <see cref="string"/>.</returns>
        public static string GetManifestResourceText(this Assembly assembly, string name)
        {
            string text = null;
            using (var stream = assembly.GetManifestResourceStream(name))
            {
                if (stream != null)
                {
                    using (var streamReader = new StreamReader(stream))
                    {
                        text = streamReader.ReadToEnd();
                    }
                }
            }

            return text;
        }
    }
}
