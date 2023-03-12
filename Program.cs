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

            USBData usb = new USBData(); //assigns the class USBdata as an object called usb.
            
            usb.DisplayData();;

            Console.WriteLine("\nTask 1:\n---------------------------------\n" +
            $"The Total Data Usage of the USB Drive is: {usb.TotalDataSize()}kb\n" + //calls the TotalDataSize method from the USBData class and prints it the the console
            $"The Average Image size is: {usb.AverageDataSize()}kb\n" + //calls the AverageDataSize method from the USBData class and prints it the the console
            $"There are {usb.CountMinSize()} Images below 100kb\n" + //calls the CountMinSize method from the USBData class and prints it the the console
            "---------------------------------");

            Console.WriteLine("\nTask 2:\n---------------------------------\n" + 
            $"The largest image on the USB drive is: {usb.LargestImage()}kb\n" + //calls the LargestImage method from the USBData class and prints it the the console
            "---------------------------------");

        }
    }


}
