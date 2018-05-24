using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces
{
    public class VideoGameInfo : IFileOperations, IDisplay
    {
        //Member variables
        private string name;
        private string platform;
        private double price;
        public StreamWriter sw;

        //Default Constructor
        public VideoGameInfo()
        {
            name = "Kathy";
            platform = "windows";
            price = 0;
        }


        //Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        public string Platform
        {
            get
            {
                return platform;
            }
            set
            {
                platform = value;
            }

        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }

        }


        //Implemented Interfaces
        public void Open(string filename)
        {
            sw = new StreamWriter(filename);
        }

        public void Save()
        {
            sw.WriteLine("Name = " + name + "Platform = " + platform + "Price = " + price);
            sw.Flush();
        }

        public void Show()
        {
            Console.WriteLine("Name = " + name + "Platform = " + platform + "Price = " + price);
        }


    }
}
