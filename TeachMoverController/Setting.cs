using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmBot
{
    class Setting
    {
        private string armCharacter;

        public string ArmCharacter
        {
            get { return armCharacter; }
            set { armCharacter = value; }
        }

        private float speed;

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
