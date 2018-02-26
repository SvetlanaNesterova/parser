using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class JarFileReader : StreamReader
    {
        public JarFileReader(string path) : base(path)
        {
            if (!path.EndsWith(".jar"))
                throw new ArgumentException();
        }
    }
}
