using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Equipment
{
    public class Equipment
    {
        public string name { get; set; }
        public string description;
        public double distanceMoved;
        public double maintenanceCost;
        enum EquipmentType { Mobile = 0, Immobile = 1 };

        /// <summary>
        /// virtual method that is overriden in the derived classes
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public virtual void MoveBy(double a, double b) { }

    }
}
