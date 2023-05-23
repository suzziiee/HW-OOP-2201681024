using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_2201681024
{
    public class Midfielder : FootballPlayer 
    {
        public Midfielder(string name, int number, int age, double height)
            : base(name, number, age, height) { }
    }
}
