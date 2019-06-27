using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room
    {
        private int _Number;
        public int Number { protected set { _Number = value; } get { return _Number; } }

        public Room(int number)
        {
            this.Number = number;
        }
    }
}
