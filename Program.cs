using System;
using LeetCodeSolution.Questions;

namespace LeetCodeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Q1389.Run(new[] {0, 1, 2, 3, 4}, new[] {0, 1, 2, 2, 1});
            Q1389.Run(new[] {1, 2, 3, 4, 0}, new[] {0, 1, 2, 3, 0});
            Q1389.Run(new[] {1}, new[] {0});
        }
    }
}