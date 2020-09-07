using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleApplication1.Question
{
    public class Q20
    {
        public static void Run(string str)
        {
            Solution s = new Solution();
            Console.WriteLine(s.IsValid(str));
        }

        public class Solution
        {
            public bool IsValid(string s) {
                Stack<char> stack=new Stack<char>();
                foreach (char c in s.ToCharArray()) {
                    if (c == '(') {
                        stack.Push(')');
                    }else if (c == '{') {
                        stack.Push('}');
                    }else if (c == '['){
                        stack.Push(']');
                    }else if (stack.Count() == 0 || stack.Pop() != c){
                        return false;
                    }
                }
                return stack.Count==0;
            }
            // public bool IsValid(string s)
            // {
            //     var arr = s.ToCharArray();
            //     if (arr.Length == 0) return true;
            //     if (arr.Length % 2 != 0) return false;
            //     var stack = new List<int>();
            //     var push = "([{";
            //     var pop = ")]}";
            //     int pushIdx = 0;
            //     int popIdx = 0;
            //     foreach (char c in arr)
            //     {
            //         popIdx = pop.IndexOf(c);
            //         pushIdx = push.IndexOf(c);
            //         if (popIdx > -1)
            //         {
            //             if (stack.Count == 0)
            //             {
            //                 return false;
            //             }
            //             else if (stack[stack.Count - 1] != popIdx)
            //             {
            //                 return false;
            //             }
            //
            //             stack.RemoveAt(stack.Count - 1);
            //         }
            //         else if (pushIdx > -1)
            //         {
            //             stack.Add(pushIdx);
            //         }
            //         if (stack.Count == 0)
            //         {
            //             return true;
            //         }
            //     }
            //     return false;
            // }
        }
    }
}