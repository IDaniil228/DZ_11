namespace DZ_11
{
    internal class FewBuilding
    {
        private Building[] fewBuilding = new Building[10];
        public Building this[int index]
        {
            get { return fewBuilding[index]; }
            set { fewBuilding[index] = value; }
        }
    }
}
