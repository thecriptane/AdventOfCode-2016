﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int grade = 0;
            string code = " R1, R3, L2, L5, L2, L1, R3, L4, R2, L2, L4, R2, L1, R1, L2, R3, L1, L4, R2, L5, R3, R4, L1, R2, L1, R3, L4, R5, L4, L5, R5, L3, R2, L3, L3, R1, R3, L4, R2, R5, L4, R1, L1, L1, R5, L2, R1, L2, R188, L5, L3, R5, R1, L2, L4, R3, R5, L3, R3, R45, L4, R4, R72, R2, R3, L1, R1, L1, L1, R192, L1, L1, L1, L4, R1, L2, L5, L3, R5, L3, R3, L4, L3, R1, R4, L2, R2, R3, L5, R3, L1, R1, R4, L2, L3, R1, R3, L4, L3, L4, L2, L2, R1, R3, L5, L1, R4, R2, L4, L1, R3, R3, R1, L5, L2, R4, R4, R2, R1, R5, R5, L4, L1, R5, R3, R4, R5, R3, L1, L2, L4, R1, R4, R5, L2, L3, R4, L4, R2, L2, L4, L2, R5, R1, R4, R3, R5, L4, L4, L5, L5, R3, R4, L1, L3, R2, L2, R1, L3, L5, R5, R5, R3, L4, L2, R4, R5, R1, R4, L3";
            string[] codesplitted = code.Split(',');
            for (int i = 0; i < codesplitted.Count(); i++)
            {
                string temp = codesplitted[i].Substring(2, codesplitted[i].Length - 2);
                if (codesplitted[i][1] == 'R')
                {
                    grade = grade + 90;
                    if (grade >= 360)
                    {
                        grade = 0;
                    }
                }
                else
                {
                    grade = grade - 90;
                    if (grade <= -360)
                    {
                        grade = 0;
                    }
                }

                if (grade == 0)
                {
                    y = y + Convert.ToInt32(temp);

                }
                else if (grade == 90 || grade == -270)
                {
                    x = x + Convert.ToInt32(temp);
                }
                else if (grade == 180 || grade == -180)
                {
                    y = y - Convert.ToInt32(temp);
                }
                else if (grade == 270 || grade == -90)
                {
                    x = x - Convert.ToInt32(temp);
                }
            }
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}