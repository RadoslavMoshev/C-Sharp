using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OOP
{
    public class Laptop
    {
        string model;
        string manufacturer;
        string processor;
        string ram;
        string graphicsCard;
        string hdd;
        string screen;
        double price;
        private Battery battery;


        public Laptop(string model, string manufacturer, string processor, string ram,
            string graphicsCard, string hdd, string screen, int price, string batType, double batLife)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Price = price;
            Battery battery = new Battery(batType, batLife);
            this.Battery = battery;
        }

        [Required]
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }

        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                this.manufacturer = value;
            }

        }
        public string Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                this.processor = value;
            }

        }
        public string Ram
        {
            get
            {
                return this.ram;
            }

            set
            {
                if (int.Parse(value) < 2)
                {
                    throw new ArgumentOutOfRangeException("Low Ram memory!");
                }

                this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }

            set
            {
                this.graphicsCard = value;
            }

        }
        public string Hdd
        {
            get
            {
                return this.hdd;
            }

            set
            {
                if (int.Parse(value) < 500)
                {
                    throw new ArgumentOutOfRangeException("Low disk space!");
                }
                this.hdd = value;
            }

        }
        public string Screen
        {
            get
            {
                return this.screen;
            }

            set
            {
                this.screen = value;
            }

        }

        [Required]
        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 600 || value > 5000)
                {
                    throw new IndexOutOfRangeException();
                }

                this.price = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public override string ToString()
        {
            StringBuilder laptopStr = new StringBuilder();
            laptopStr.AppendLine("Model: " + this.Model);
            if (this.Manufacturer != null)
            {
                laptopStr.AppendLine("Manufacturer: " + this.Manufacturer);
            }
            if (this.Processor != null)
            {
                laptopStr.AppendLine("Processor: " + this.Processor);
            }
            if (this.Ram != null)
            {
                laptopStr.AppendLine("RAM: " + this.Ram + "GB");
            }
            if (this.Hdd != null)
            {
                laptopStr.AppendLine("HDD: " + this.Hdd + "GB");
            }
            if (this.screen != null)
            {
                laptopStr.AppendLine("Screen: " + this.Screen);
            }
            if (this.Battery != null)
            {
                laptopStr.Append(this.Battery.ToString());
            }
            laptopStr.AppendLine("Price: " + this.Price + "lv");

            return laptopStr.ToString();
        }
    }
}
