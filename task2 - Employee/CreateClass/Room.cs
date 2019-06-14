using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room
    {
        private int _number;
        public int number { protected set { _number = value; } get { return _number; } }

        public Room(int number)
        {
            this.number = number;
        }
    }
}
