using System;
using ConsoleApplication1.Question;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // Q14.Run(new[] {"flower", "flow", "flight"});
            // Q14.Run(new[] {"dog", "racecar", "car"});
            // Q14.Run(new[] {"aa", "a"});
            // Q1512.Run(new []{1,2,3,1,1,3});
            // Q1512.Run(new []{1,1,1,1});
            // Q1512.Run(new []{1,2,3});
            // Q20.Run("){");
            // Q20.Run("((");
            // Q20.Run("(]");
            // Q20.Run("([)]");
            // Q20.Run("{[]}");
            // Q1480.Run(new []{1,2,3,4});
            // Q1480.Run(new []{1,1,1,1});
            // Q665.Run(new []{4,2,3});//True 
            // Q665.Run(new []{4,2,1});//False
            // Q665.Run(new []{-1,4,2,3});//True 
            // Q665.Run(new []{3,4,2,3});//False
            // Q665.Run(new []{1,2,5,3,3});//True
            // Q665.Run(new []{3,2,3,2,4});//False
            // Q665.Run(new []{1,3,4,2,5});//true
            // Q859.Run("ab","ba");//t
            // Q859.Run("ab", "ab");//f
            // Q859.Run("aa", "aa");//t
            // Q859.Run("aaaaaaabc", "aaaaaaacb");//t
            // Q859.Run("","aa");//f
            // Q859.Run("abcaa", "abcbb");//f
            // Q859.Run("ab", "ca");//f
            // Q859.Run("abab", "abab");//t
            // Q859.Run("abcd", "abcd");//f
            // Q26.Run(new []{1,1,2});
            // Q26.Run(new []{0,0,1,1,1,2,2,3,3,4});
            // Q189.Run(new []{1,2,3,4,5,6,7},3);
            // Q1470.Run(new []{1,2,3,4,5,6},3);
            // Q1470.Run(new []{2,5,1,3,4,7},3);
            // Q38.Run(4);
            // Q53.Run(new []{-2,1,-3,4,-1,2,1,-5,4});//6
            // Q53.Run(new []{-2,-1});//-1
            // Q53.Run(new []{1,2});//3
            // Q53.Run(new []{8,-19,5,-4,20});//21
            // Offer58.Run("abcdefg", 2);
            // Offer58.Run("lrloseumgh",6);
            // Offer64.Run(3);//6
            // Offer64.Run(9);//45
            // LCP06.Run(new[] {2,3,10});
            // Q1281.Run(234);
            // Q1281.Run(690);
            // Q1561.Run(new []{2,4,5});
            // Q1561.Run(new []{9,8,7,6,5,1,2,3,4});
            // Q1561.Run(new []{2,4,1,2,7,8});
            // REL1.Run();
            // Q1313.Run(new []{1,1,2,3});
            Q5491.Run(new int[][]
            {
                new[] {1, 2, 3},
                new[] {4, 5, 6},
                new[] {7, 8, 9}
            });
            Q5491.Run(new int[][]
            {
                new[] {1, 1, 1, 1},
                new[] {1, 1, 1, 1},
                new[] {1, 1, 1, 1},
                new[] {1, 1, 1, 1}
            });
            Q5491.Run(new int[][]
            {
                new[] {5}
            });
            Q5491.Run(new int[][]
            {
                new[] {7, 3, 1, 9},
                new[] {3, 4, 6, 9},
                new[] {6, 9, 6, 6},
                new[] {9, 5, 8, 5}
            });
        }
    }
}