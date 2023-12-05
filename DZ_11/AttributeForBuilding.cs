using System;

namespace DZ_11
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class AttributeForBuilding : Attribute
    {
        string developer;
        string org;
        public string Developer
        {
            get { return developer; }
        }
        public string Org
        {
            get { return org; }
        }
        public AttributeForBuilding(string name, string org)
        {
            developer = name;
            this.org = org;
        }
    }
}
