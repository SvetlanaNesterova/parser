using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class ClassDescription
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public ClassModifiers Modifiers { get; set; }
        public List<ConstructorDescription> Constructors { get; set; }
        public List<MethodDescription> Methods { get; set; }
        public List<ClassDescription> NestedClasses { get; set; }

        public ClassDescription(string name)
        {
            throw new NotImplementedException();

            //Name = name;
            //Constructors = new List<ConstructorDescription>();
            //Methods = new List<MethodDescription>();
            //NestedClasses = new List<ClassDescription>();
        }
    }
}