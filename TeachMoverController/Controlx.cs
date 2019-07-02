using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmBot
{
    class Controlx
    {
        private List<string> listCommands;

        public List<string> ListCommands
        {
            get { return listCommands; }
            set { listCommands = value; }
        }

        private string currentCommand;

        public string CurrentCommand
        {
            get { return currentCommand; }
            set { currentCommand = value; }
        }

        private float bodyValue;

        public float BodyValue
        {
            get { return bodyValue; }
            set { bodyValue = value; }
        }

        private float shoulderValue;

        public float ShoulderValue
        {
            get { return shoulderValue; }
            set { shoulderValue = value; }
        }

        private float armValue;

        public float ArmValue
        {
            get { return armValue; }
            set { armValue = value; }
        }

        private float gripperG;

        public float GripperG
        {
            get { return gripperG; }
            set { gripperG = value; }
        }

        private float gripperRotate;

        public float GripperRotate
        {
            get { return gripperRotate; }
            set { gripperRotate = value; }
        }

        private float gripperU;

        public float GripperU
        {
            get { return gripperU; }
            set { gripperU = value; }
        }
    }
}
