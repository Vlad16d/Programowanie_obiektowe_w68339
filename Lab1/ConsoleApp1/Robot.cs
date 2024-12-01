using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace project
{
    class Robot
    {

        public static int count = 0;

        private string name;
        private int weight;
        private byte[] coordinates;

        public Robot(string _name, int _weight, byte[] _coordinates) 
        {
            Console.WriteLine("Object has been created ");
            setValues(_name, _weight, _coordinates);
            count++;
        }

        public Robot() {}

        public void setValues(string _name, int _weight, byte[] _coordinates)
        {
            name = _name;
            weight = _weight;
            coordinates = _coordinates;
            count++;
        }

        public void printValues()
        {
            Console.WriteLine(name + " weight " + weight + ".Coordinates: ");
            foreach(byte el in coordinates)
                Console.WriteLine(el);
        }

        public static void Print() 
        { 
            Console.WriteLine("\nCount is " + count);
        }

    }
}
