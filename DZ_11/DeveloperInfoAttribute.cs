using System;

namespace DZ_11
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class DeveloperInfoAttribute : System.Attribute
    {
        private string developer;
        private string date;
        public string Developer
        {
            get
            {
                return developer;
            }
        }
        public string Date
        {
            get
            {
                return date;
            }
        }

        public DeveloperInfoAttribute(string name, string date)
        {
            this.developer = name;
            this.date = date;
        }
    }
}
