using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class MethodModifiers
    {
        public bool IsStatic { get; private set; }
        public bool IsPublic { get; private set; }
        public bool IsProtected { get; private set; }
        // Было бы хорошо знать о protected-методах 
        // для наследования классов прокси. 
        // Вроде от этого проблем у нас не прибавляется
        public bool IsAbstract { get; private set; }
        public bool IsFinal { get; private set; } // не может быть переопределен в наследниках
    }
}
