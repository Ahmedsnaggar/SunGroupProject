using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGroupProject.Structs
{
    public struct Coffee
    {
        public int _strength;
        private string _bean;
        private string _origin;
        public int strength { get { return _strength; } }
        public string bean { get { return _bean; } set { _bean = value; } }
        public string origin { get { return _origin; } set { _origin = value; } }
        public Coffee(int strength, string bean, string origin)
        {
            _strength = strength;
            _bean = bean;
            _origin = origin;
        }

    }
}
