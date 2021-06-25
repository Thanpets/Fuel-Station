using FuelStationProgram.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationProgram.Impl
{
    class Items : Entity
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }

        public decimal Price { get; set; }
        public decimal Cost { get; set; }



    }
}
