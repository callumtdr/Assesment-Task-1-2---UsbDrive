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
            for (int i = 0; i < imageName.Length; i++)  //Loops for the length of the array.
            {
                Console.WriteLine($"{imageName[i]}: {imageSize[i]}kb"); //prints the imageName and imageSize to the console.
            }
        }

        /// <summary>
        /// This method returns the total of all int's stored within the imageSize array.
        /// </summary>
        /// <returns></returns>
        public int TotalDataSize()
        {
            int total = 0; //Declares the total variable and initializes it to 0.

            foreach (int i in imageSize) //Uses a foreach loop to itterate through each integer "i" in the imageSize array.
            { 
                total = total + i; //Adds each value of "i" to the total variable.
            }
            int totalSize = total; //Declares a new variable called totalSize and initlize's it to total.

            return totalSize; //Returns the totalSize.
        }

        /// <summary>
        /// this Method returns the the total of all ints in imageSize divided by the length of the array for the average int.
        /// </summary>
        /// <returns></returns>
        public double AverageDataSize()
        {
            int total = 0; //Declares the total variable and initializes it to 0.

            foreach (int i in imageSize) //Uses a foreach loop to itterate through each integer "i" in the imageSize array.
            {
                total = total + i; //Adds each value of "i" to the total variable.
            }
            double average = total / imageSize.Length; //Declares a new variable, average, and initializes it as total divided by the length of the array.

            return average; //Returns the average variable.
        }

        /// <summary>
        /// This method runs through the imageSize array and compares each item, if the item is less than 100, the total count increases by 1. 
        /// </summary>
        /// <returns></returns>
        public int CountMinSize() 
        {
            int count = 0; //Declares the count variable and initializes it to 0.

            foreach (var i in imageSize) //Uses a foreach loop to itterate through each integer "i" in the imageSize array.
            {
                if (i < 100) //checks if "i" in imageSize is less than 100.
                {
                    count++; //if "i" is less than 100, this adds 1 to count.
                }
            }
            int totalCount = count; //Declares a new variable, totalCount, and initializes it as count.

            return totalCount;  //Returns the totalCount Variable.
        }

        /// <summary>
        /// this method runs through the imageSize array and returns the largest int held in the array.
        /// </summary>
        /// <returns></returns>
        public int LargestImage()
        {
            int maxValue = imageSize[0]; //Declares a new variable, maxValue, and initializes it to the first index of imageSize,

            foreach (int i in imageSize) //Uses a foreach loop to itterate through each integer "i" in the imageSize array.
            {
                if (i > maxValue) //Checks if each "i" is greater then the current value of maxValue.
                    maxValue = i; //Updates maxValue if "i" is greater than the previous maxValue.
            }

            return maxValue; //Returns the maxValue variable as the largest integer in imageSize.
        }
    }
}
