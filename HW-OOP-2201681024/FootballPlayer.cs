using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_2201681024
{
    public abstract class FootballPlayer : Person
    {
        public FootballPlayer(string name, int number, int age, double height): base(name,age)
        {
            this.Number = number; ;
            this.Height = height;
        }
        public int Number { get; private set; }
        public double Height { get; private  set; }
    }
}
