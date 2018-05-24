using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoGameInfo vg = new VideoGameInfo();
            vg.Name = "Civilization 6";
            vg.Platform = "PC";
            vg.Price = 59.99;
            vg.Open("civ.txt");
            vg.Save();

            IFileOperations ifo;
            ifo = vg;           

            IDisplay idisp = vg;



        }
    }
}
