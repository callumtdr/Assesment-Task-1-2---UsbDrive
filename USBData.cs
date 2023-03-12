using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{   
    internal class USBData
    {
        private string[] imageName = { "Image1", "Image2", "Image3", "Image4", "Image5", "Image6", "Image7", "Image8", "Image9", "Image10" };
        private int[] imageSize = { 234, 352, 8735, 423, 16089, 3728, 7382, 1623, 50, 75 };
        

        /// <summary>
        /// This method uses a for loop to run through array for the length of the array and prints the imageName and imageSize to the user.
        /// </summary>
        public void DisplayData()
        {
            for (int i = 0; i < imageName.Length; i++) 
            {
                Console.WriteLine($"{imageName[i]}: {imageSize[i]}kb");
            }
        }

        /// <summary>
        /// This method returns the total of all int's stored within the imageSize array.
        /// </summary>
        /// <returns></returns>
        public int TotalDataSize()
        {
            int total = 0;
            foreach (int i in imageSize) 
            { 
                total = total + i;
            }
            int totalSize = total;
            return totalSize;
        }

        /// <summary>
        /// this Method returns the the total of all ints in imageSize divided by the length of the array for the average int.
        /// </summary>
        /// <returns></returns>
        public double AverageDataSize()
        {
            int total = 0;

            foreach (int i in imageSize)
            {
                total = total + i;
            }
            double average = total / imageSize.Length;

            return average;
        }

        /// <summary>
        /// This method runs through the imageSize array and compares each item, if the item is less than 100, the total count increases by 1. 
        /// </summary>
        /// <returns></returns>
        public int CountMinSize() 
        {
            int count = 0;

            foreach (var i in imageSize)
            {
                if (i < 100)
                {
                    count++;
                }
            }
            int totalCount = count;

            return totalCount;
        }

        /// <summary>
        /// this method runs through the imageSize array and returns the largest int held in the array.
        /// </summary>
        /// <returns></returns>
        public int LargestImage()
        {
            int maxValue = imageSize[0];

            foreach (int item in imageSize)
            {
                if (item > maxValue)
                    maxValue = item;
            }

            return maxValue;
        }
    }
}
