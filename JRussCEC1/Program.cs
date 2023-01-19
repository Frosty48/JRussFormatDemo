using System;

namespace RussCEC1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] nums = { 1.0f, 5.0f, 3.0f, 2.5f, 1.6f, 2.6f };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0,-10}", nums[i]);
                if ((i + 3) % 3 == 0)
                {
                    Console.WriteLine();//adds a character
                }
            }

        }
    }
}