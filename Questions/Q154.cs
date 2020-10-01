namespace LeetCodeSolution.Questions
{
    public class Q154
    {
        public static void Run()
        {
            Solution s = new Solution();
            int[] num = new[] {2, 2, 2, 0, 1};
            var res = s.MinArray(num);
        }
        public class Solution {
            public int MinArray(int[] numbers)
            {
                int left = 0, right = numbers.Length-1;
                while (left < right)
                {
                    int mid = (right + left) / 2;
                    if (numbers[mid] < numbers[right])
                    {
                        right = mid;
                    }else if (numbers[mid] > numbers[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right--;
                    }
                }

                return numbers[left];
            }
        }
    }
}