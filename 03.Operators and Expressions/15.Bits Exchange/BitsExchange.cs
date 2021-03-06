﻿/*
 * Problem 15.* Bits Exchange

    Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

Examples:
n 	binary representation of n 	binary result 	result
1140867093 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
255406592 	00001111 00111001 00110010 00000000 	00001000 00111001 00110010 00111000 	137966136
4294901775 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
5351 	00000000 00000000 00010100 11100111 	00000100 00000000 00010100 11000111 	67114183
2369124121 	10001101 00110101 11110111 00011001 	10001011 00110101 11110111 00101001 	2335569705
 * 
 */

using System;


class BitsExchange
{
    static void Main(string[] args)
    {
        int n = 5351; //user input
        int m = 0;          //resulting number

        //Positions 
        int[] bitsApositions = new int[3] { 3, 4, 5 };
        int[] bitsBpositions = new int[3] { 24, 25, 26 };

        int[] bitsAcontent = new int[3] { 0, 0, 0 };
        int[] bitsBcontent = new int[3] { 0, 0, 0 };
        int mask = 1;

        for (int i = 0; i < 3; i++)
        {
            mask = 1 << bitsApositions[i];
            bitsAcontent[i] = (n & mask) >> bitsApositions[i];
            Console.WriteLine("bitsAcontent ", Convert.ToString(bitsAcontent[i], 2));

        }

        for (int i = 0; i < 3; i++)
        {
            mask = 1 << bitsBpositions[i];
            bitsBcontent[i] = (n & mask) >> bitsBpositions[i];
            Console.WriteLine("bitsBcontent ", Convert.ToString(bitsBcontent[i], 2));

        }



        for (int i = 0; i < 3; i++)
        {
            mask = 1 << bitsBpositions[i];
            m = (bitsAcontent[i] == 0) ? n & ~mask : n | mask;
            mask = 1 << bitsApositions[i];
            m = (bitsBcontent[i] == 0) ? n & ~mask : n | mask;

        }

        Console.WriteLine("Number after bit swap is: {0}", m);

    }
}