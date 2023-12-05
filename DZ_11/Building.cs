namespace DZ_11
{
    [AttributeForBuilding("Developer", "Газпром")]
    internal class Building
    {
        private static int number;
        private int height;
        private int floors;
        private int apartments;
        private int entrance;

        public Building() { }
        public Building(int height, int floors, int apartments, int entrance)
        {
            number++;
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrance = entrance;
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }
        public int Apartments
        {
            get { return apartments; }
            set { apartments = value; }
        }
        public int Entrance
        {
            get { return entrance; }
            set { entrance = value; }
        }

        public double HeightOfFloors(int floors, int height)
        {
            return (double)height / floors;
        }
        public double ApartmentsInEntrance(int apartments, int entrance)
        {
            return (double)apartments / entrance;
        }
        public double ApartmentsOnTheFloor(int apartments, int floors)
        {
            return (double)(apartments / floors);
        }
        public string ShowInfo()
        {
            return $"Номер дом - {number}, высота - {height}, этажи - {floors}, квартиры - {apartments}, подъезды - {entrance}";
        }
    }
}
