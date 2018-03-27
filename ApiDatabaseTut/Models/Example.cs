using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDatabaseTut.Models
{
    public class Example
    {
        public string Word { get; set; }
        public Bottle Bottle { get; set; }


    }

    public class Bottle
    {
        public int Size { get; set; }
        public bool IsFull { get; set; }

    }
}
