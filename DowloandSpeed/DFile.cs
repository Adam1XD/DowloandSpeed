using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DowloandSpeed
{
    public class DFile
    {
        private double Gygabytes { get; set; }
        private double Megabytes { get; set; }

        private double FullSize()
        {
            return Gygabytes * 1000 + Megabytes;
        }

        public string DowloandSpeed(double dowloandSpeed)
        {
            double totalSeconds = FullSize() / dowloandSpeed;
            int hours = (int)totalSeconds / 3600;
            int minutes = (int)(totalSeconds % 3600) / 60;
            int seconds = (int)(totalSeconds % 60);
            return $"Your file will be downloaded in: {hours} hours - {minutes} minutes - {seconds} seconds.";
        }

        public void Choice()
        {
            bool error = false;
            do
            { 
                Console.WriteLine("Choose your Insert type:\n1 gygabytes\n2 megabytes\n3 both");
                char choice = char.Parse(Console.ReadLine());
                switch(choice)
                {
                    case '1':
                        Console.WriteLine("Insert the file size in gigabytes: ");
                        Gygabytes = double.Parse(Console.ReadLine());
                        break;
                    case '2':
                        Console.WriteLine("Insert the file size in megabytes: ");
                        Megabytes = double.Parse(Console.ReadLine());
                        break;
                    case '3':
                        Console.WriteLine("Insert the file size in gigabytes: ");
                        Gygabytes = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insert the file size in megabytes: ");
                        Megabytes = double.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Error. Try again.");
                        error = true;
                        break;
            
                }
            }while(error == true);
        }
    }
}
