using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Pineapple : Fruit
    {
        public float _weight;
        public string _originCountry;
        public override bool IsThisMyFavorite()
        {
            return true;
        }
        public override string ToString()
        {
            return $"{base.ToString()} weight : {_weight} origin country : {_originCountry} ";
        }
    }
}
