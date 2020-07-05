using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void PrintColor(Apple a)
        {
            Console.WriteLine(a._color);
            Console.WriteLine(a);
            
        }
        static void PrintSize(Banana b)
        {
            Console.WriteLine(b._size);
            Console.WriteLine(b);
        }

        static void PrintFruitArray(Fruit[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public int GetTotalCalories()
        {
            return 
        }
        public bool ContainsMyFavoriteFruit()
        {
            return 
        }
      
        static void Main(string[] args)
        {
            Apple a = new Apple()
            {
                _name = "apple",
                _calories = 52,
                _color = "red",
                _pinklady = true
            };
            Console.WriteLine(a);
            Banana b = new Banana()
            {
                _name = "banana",
                _calories = 88,
                _hasBalackSpots = true,
                _isGreen = false,
                _size = 15.3f
            };
            Console.WriteLine(b);
            Pineapple p = new Pineapple()
            {
                _name = "pineapple",
                _calories = 50,
                _originCountry = "Costa Rica",
                _weight = 3.2f
            };
            Console.WriteLine(p);
            Orange o = new Orange()
            {
                _name = "orange",
                _calories = 47,
                _isSweet = false,
                _shape = "round"
            };
            Console.WriteLine(o);


            Fruit[] fruits = new Fruit[] { b, p, a };
            Fruitsalad fruitsalad1 = new Fruitsalad()
            {
                _fruits = fruits
            };





        }
    }
}
