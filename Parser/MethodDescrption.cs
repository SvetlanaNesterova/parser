using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class MethodDescription
    {
        public string MethodName;
        public MethodModifiers Modifiers;
        public string OutputType;
        public string[] InputTypes;

        public MethodDescription(string name)
        {
            MethodName = name;
        }
    }
}
