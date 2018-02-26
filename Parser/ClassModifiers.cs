using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class ClassModifiers
    {
        public bool IsAbstract { get; private set; }
        public bool IsFinal { get; private set; } // не может иметь наследников

        // какие могут быть вложенные классы?
        public bool IsStatic { get; private set; } // только для вложенных классов
        public bool IsPublic { get; private set; }
        public bool IsProtected { get; private set; }
    }
}
