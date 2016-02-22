using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNMehmet
{
    class ANNPart1
    {
        private float sunday;
        private float monday;
        private float tuesday;
        private float wednesday;
        private float thursday;
        private float friday;
        private float saturday;

        private float FFMC;
        private float DMC;
        private float DC;
        private float ISI;
        private float temp;
        private float RH;
        private float wind;
        private float rain;
        private float area;

        public ANNPart1(String InputsString)
        {
            String[] Inputs = InputsString.Split(',');

            getDayValues(Inputs[0]);
            FFMC = float.Parse(Inputs[1]);
            DMC = float.Parse(Inputs[2]);
            DC = float.Parse(Inputs[3]);
            ISI = float.Parse(Inputs[4]);
            temp = float.Parse(Inputs[5]);
            RH = float.Parse(Inputs[6]);
            wind = float.Parse(Inputs[7]);
            rain = float.Parse(Inputs[8]);
            area = float.Parse(Inputs[9]);
        }

        private void getDayValues(String Day)
        {
            switch (Day)
            {
                case "sun":
                    sunday = 1f;

                    break;

                case "mon":
                    monday = 1f;

                    break;

                case "tue":
                    tuesday = 1f;

                    break;

                case "wed":
                    wednesday = 1f;

                    break;

                case "thu":
                    thursday = 1f;

                    break;

                case "fri":
                    friday = 1f;

                    break;

                case "sat":
                    saturday = 1f;

                    break;
            }
        }

        public float getOutput()
        {
            return;
        }
    }
}
