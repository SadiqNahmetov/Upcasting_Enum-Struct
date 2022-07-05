using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting.Models
{
   public class Params
    {

        public static void GetElements(params int[] nums)
        {
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
        static void Sum(int[] arr)
        {

        }


    }
}
