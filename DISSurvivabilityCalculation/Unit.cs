using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Type
{
    NetworkDevice,
    HostDevice,
    Connection,
    Unknown
}

namespace DISSurvivabilityCalculation
{
    class Unit
    {
        internal Type Type { get => type;}
        public string Name { get => name;}
        public double Survivability { get => survivability; set => survivability = value; }
        internal Unit Device1 { get => device1; }
        internal Unit Device2 { get => device2; }

        private readonly Unit device1;
        private readonly Unit device2;
        private double survivability;
        private readonly string name;
        private readonly Type type;


        public Unit()
        {
            type = Type.Unknown;
            name = "Invalid unit";
            survivability = 0;
        }
        public Unit(Type _type, string _name, double _survivability)
        {
            type = _type;
            name = _name;
            survivability = _survivability;
            device1 = null;
            device2 = null;
        }
        public Unit(Type _type, string _name, double _survivability, Unit from, Unit to)
        {
            type = _type;
            name = _name;
            survivability = _survivability;
            device1 = from;
            device2 = to;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Unit objAsUnit = obj as Unit;
            if (objAsUnit == null) return false;
            else return Equals(objAsUnit);
        }
        public bool Equals(Unit other)
        {
            if (other == null) return false;
            return (this.Type.Equals(other.Type) && this.name.Equals(other.Name));
        }
    }
}
