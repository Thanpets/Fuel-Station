using FuelStationProgram.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationProgram.Impl
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CardNumber { get; set; }

    }
}
