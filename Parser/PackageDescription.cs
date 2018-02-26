using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Parser
{
    public class PackageDescription
    {
        private Dictionary<string, ClassDescription> definedClasses;
        /// <summary>
        /// Классы, описания которых присутствуют в данном пакете
        /// (для них были созданы ClassDescription'ы).
        /// </summary>
        public Dictionary<string, ClassDescription> DefinedClasses
        {
            get
            {
                return new Dictionary<string, ClassDescription>(definedClasses);
            }
        }

        private List<string> subpackagesClasses;
        /// <summary>
        /// Классы, описания которых находятся в подпакетах этого пакета.
        /// </summary>
        public List<string> SubpackagesClasses
        {
            get
            {
                return new List<string>(subpackagesClasses);
            }
        }

        private List<string> undefinedClasses;
        /// <summary>
        /// Классы (и типы(?)), описания которых не были 
        /// обнаружены в этом пакете и его подпакетах.
        /// </summary>
        public List<string> UndefinedClasses
        {
            get
            {
                return new List<string>(undefinedClasses);
            }
        }

        private List<PackageDescription> subpackages;
        public List<PackageDescription> SubPackages
        {
            get
            {
                return new List<PackageDescription>(subpackages);
            }
        }

        /// <summary>
        /// Имя пакета (например, "java.lang.reflect")
        /// </summary>
        public string Name { get; private set; }

        public PackageDescription(JarFileReader source)
        {
            /*
             * Извлекает данные о классах, имеющихся в данном jar-файле.
             * С помощью Java Reflection API Proxy для каждого класса
             * создает его описание (ClassDescription).
             * 
             * Этот метод будет реализован только на второй итерации.
             */
            throw new NotImplementedException();
        }

        public PackageDescription(JsonFileReader source)
        {
            /*
             * По DSL-описанию пакета в формате Json извлекает данные
             * о классах, имеющихся в данном пакете, и "вручную" создает
             * для каждого класса его описание (ClassDescription).
             * 
             * Этот метод будет реализован в ближайшее время.
             */

            throw new NotImplementedException();
            
            //string jsonPackageDecscription = source.ReadToEnd();
            //var self = JsonConvert
            //    .DeserializeObject<PackageDescription>(jsonPackageDecscription);
            //Name = self.Name;
            //classes = self.classes;
            //subpackages = self.subpackages;
        }
    }
}
