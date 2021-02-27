﻿using System;

namespace AIE_Get_Two_Lengths
{
    class Program
    {
        static int[] GetTwoLengths(string a, string b)
        {
            int[] lengths = new int[2];
            lengths[0] = a.Length;
            lengths[1] = b.Length;
            return lengths;
        }
       

        static void Main(string[] args)
        {
            var strLengths1 = GetTwoLengths("hello", "world");
            var strLengths2 = GetTwoLengths("", "hello world");
            var strLengths3 = GetTwoLengths("aaaa", "bbbbbbbbbbbbbbb");

            Console.WriteLine(strLengths1[0]); // 5
            Console.WriteLine(strLengths1[1]); // 5

            Console.WriteLine(strLengths2[0]); // 0
            Console.WriteLine(strLengths2[1]); // 11

            Console.WriteLine(strLengths3[0]); // 4
            Console.WriteLine(strLengths3[1]); // 15
        }
    }
}
