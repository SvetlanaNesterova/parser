using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class JsonFileReader: StreamReader
    {
        public JsonFileReader(string path) : base(path)
        {
            if (!path.EndsWith(".json"))
                throw new ArgumentException();
        }
    }
}
