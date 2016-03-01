using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OOP
{
    public class Battery
    {
        string batteryType;
        double batteryLife;

        public Battery(string battery, double batteryLife)
        {
            BatteryType = battery;
            BatteryLife = batteryLife;
        }
        public string BatteryType
        {
            get
            {
                return batteryType;
            }

            set
            {
                batteryType = value;
            }
        }
        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }

            set
            {
                this.batteryLife = value;
            }
        }

        public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Batter type: " + batteryType);
                sb.AppendLine("Battery life: " + batteryLife + " hrs");
                return sb.ToString();
            }
    }
}
