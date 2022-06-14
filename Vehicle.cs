using System;

namespace DesignPatternFactory
{
    public abstract class Vehicle
    {
        internal int capacity;
        public string GetData()
        {
            return GetType().ToString().Split(".")[1];
        }
        public int GetCapacity()
        {
            return capacity;
        }
        public void AddPassengers(int passengers)
        {
            if (capacity < passengers)
            {
                throw new Exception(GetData() +" reached max capacity");
            }
            else
                capacity -= passengers;
        }

    }
}
