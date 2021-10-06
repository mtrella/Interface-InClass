using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class_7.Models
{

    // New interface class
    public interface Shield
    {
        public string Name { get; set; }

        public string ShieldHealth { get; set; }

        void Block(){}
        void Health(){}

        void Durability(){}
    }
}