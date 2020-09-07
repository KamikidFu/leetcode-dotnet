using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApplication1.Question
{
    public class Q859
    {
        public static void Run(string A, string B)
        {
            Solution s = new Solution();
            Console.WriteLine(s.BuddyStrings(A,B));
        }
        public class Solution {
            public bool BuddyStrings(string A, string B)
            {
                if (A.Length != B.Length) return false;
                if (A.Length < 2) return false;
                Dictionary<int, string> dict = new Dictionary<int, string>();
                bool isRedundant = false;
                List<char> pre = new List<char>();
                var len = A.Length >= B.Length ? B.Length : A.Length;
                for (int i = 0; i < len; i++)
                {
                    if (A[i] != B[i])
                    {
                        var str = A[i] + "," + B[i];
                        dict.Add(i,str);
                    }

                    if (pre.Contains(A[i]))
                    {
                        isRedundant = true;
                    }
                    else
                    {
                        pre.Add(A[i]);
                    }
                    
                    if (dict.Count() > 2)
                    {
                        return false;
                    }
                }

                if (dict.Count == 0)
                {
                    return isRedundant;
                }

                if (dict.Count == 2)
                {
                    var str1 = dict.First().Value.Split(',');
                    var str2 = dict.Last().Value.Split(',');
                    return str1[0].Equals(str2[1]) && str1[1].Equals(str2[0]);
                }

                return false;
            }
        }
    }
}