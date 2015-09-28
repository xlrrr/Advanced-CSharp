using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays__Lists__Stacks__Queues__HomeWork
{
    class SortArray
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(nums);
            for(int i=0;i<nums.Length;i++){
                Console.Write(nums[i]);
            }


        }
    }
}
