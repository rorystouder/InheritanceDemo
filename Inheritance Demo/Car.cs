namespace Inheritance_Demo
{
    class Car : Automobile
    {
        private int _doors;
        public Car()
        {
            _doors = 0;
        }

        public int Doors
        {
            get { return _doors; }
            set { _doors = value; }
        }
    }
}