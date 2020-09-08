using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCodeSolution.Questions
{
    public class REL1
    {
        
        // 真实代码面试
        // 公司： Movio - company of Vista Group International Ltd (NZX/ASX:VGL) @ AKL
        // 时间：31 Aug 2020
        // 生成一组（1000个）四位PIN码(0~9，第一位可为0)，并且满足：
        // 1. 唯一性，1000个PIN码各不相同
        // 2. 连续两位不允许相同
        // 3. 连续三位不允许递增
        public static void Run()
        {
            System.Diagnostics.Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //  开始监视代码运行时间
            Solution s = new Solution();
            string[] arr = s.GetPinArray();
            stopwatch.Stop();  //停止监视
            TimeSpan timespan = stopwatch.Elapsed;  //获取当前实例测量得出的总时间
            Console.WriteLine("打开窗口代码执行时间：{0}(毫秒)", timespan.TotalMilliseconds);  //总毫秒数
        }
        public class Solution
        {
            private List<string> _pinArray;
            private List<string> _banned;
            private Random _rand;
            private StringBuilder _sb;

            public Solution()
            {
                _pinArray = new List<string>();
                _banned = new List<string>();
                _rand = new Random();
                _sb = new StringBuilder();
                GeneratePinArray();
            }
            public string[] GetPinArray()
            {
                return _pinArray.ToArray();
            }

            private void GeneratePinArray()
            {
                string temp = GeneratePin();
                for (int i = 0; i < 1000; )
                {
                    while (IsSame(temp) 
                           || IsIncrease(temp) 
                           || _banned.Contains(temp)
                           || _pinArray.Contains(temp))
                    {
                        temp = GeneratePin();
                    }
                    _pinArray.Add(temp);
                    i++;
                }
            }

            private string GeneratePin()
            {
                _sb = new StringBuilder();
                for (int i = 0; i < 4; i++)
                {
                    _sb.Append(_rand.Next(0, 9));
                }
                return _sb.ToString();
            }

            private bool IsSame(string str)
            {
                for (int i = 1; i < 4; i++)
                {
                    if (str[i] == str[i - 1])
                    {
                        _banned.Add(str);
                        return true;
                    }
                }
                
                return false;
            }

            private bool IsIncrease(string str)
            {
                for (int i = 2; i < 4; i++)
                {
                    if (str[i] > str[i - 1] && str[i - 1] > str[i - 2])
                    {
                        _banned.Add(str);
                        return true;
                    }
                }

                return false;
            }
        }
    }
}