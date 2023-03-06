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
        /// This code uses a for loop to run through arry for the length of the array and prints the imageName and imageSize to the user.
        /// </summary>
        public void DisplayData()
        {
            for (int i = 0; i < imageName.Length; i++)
            {
                Console.WriteLine($"{imageName[i]}: {imageSize[i]}kb");
            }
        }

        /// <summary>
        /// This code returns the total of all int's stored within the imageSize array.
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
        /// this code returns the the total of all ints divided by the length of the array for the average int.
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
        /// This code runs through the imageSize array and compares each item, if the item is less than 100, the total count increases by 1. 
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
        /// this code runs through the imageSize array and returns the largest int held in the array.
        /// both arrays were used to create a tuple by running through the arrays for their length.
        /// Tuple was used to return both imageName and ImageSize for the largest image.
        /// i deemed this unnescesary.
        /// </summary>
        /// <returns></returns>
        /* public Tuple<string, int> LargestImage()
         {
             Tuple<string, int>[] imageInfo = new Tuple<string, int>[imageName.Length];

             for (int i = 0; i < imageName.Length; i++)
             {
                 imageInfo[i] = Tuple.Create(imageName[i], imageSize[i]);
             }

             var maxValue = imageInfo[0];
             foreach (var i in imageInfo) 
             { 
                 if (i.Item2 > maxValue.Item2)
                 {
                     maxValue = i;
                 }

             }

             return maxValue;
         }*/

        /// <summary>
        /// this code runs through the imageSize array and returns the largest int held in the array.
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
