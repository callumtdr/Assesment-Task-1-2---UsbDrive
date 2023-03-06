using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading Drive Data ...");

            USBData usb = new USBData();
            
            usb.DisplayData();

            var largestImage = usb.LargestImage();

            Console.WriteLine("\nTask 1:\n---------------------------------");

            Console.WriteLine($"The Total Data Usage of the USB Drive is: {usb.TotalDataSize()}kb");

            Console.WriteLine($"The Average Image size is: {usb.AverageDataSize()}kb");

            Console.WriteLine($"There are {usb.CountMinSize()} Images below 100kb");

            Console.WriteLine("---------------------------------");

            Console.WriteLine("\nTask 2:\n---------------------------------");
            
            Console.WriteLine($"The largest image on the USB drive is: {usb.LargestImage()}kb");

            Console.WriteLine("---------------------------------");

        }
    }


}
