using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.Test
{
    public class Simple
    {
        private static readonly NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        [Fact]
        public void TwoSum()
        {
            var result = new int[2];
            var dict = new Dictionary<int, int>();
            var nums = new List<int> { 2, 7, 11, 15 }.ToArray();
            var target = 9;
            log.Info($"nums is {string.Join(',', nums)} ,target is {target}");
            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    result = new int[] { i, dict[target - nums[i]] };
                }
                dict[nums[i]] = i;
            }
            log.Info($"nums is {string.Join(',', nums)} ,target is {target}, the nums of index is {string.Join(',', result)}");
        }

        [Fact]
        public void ReverseString()
        {
            var s = "leetcode".ToCharArray();
            log.Info($"source array is {string.Join(',', s)}");
            var length = s.Length;
            for (var i = 0; i < length / 2; i++)
            {
                var tmp = s[i];
                s[i] = s[length - 1 - i];
                s[length - 1 - i] = tmp;
            }
            log.Info($"process array is {string.Join(',', s)}");
        }

        [Fact]
        public void RomanToInteger()
        {
            Dictionary<char, int> dict = new Dictionary<char, int> {
            {'I',1 },
            {'V',5 },
            {'X',10 },
            {'L',50 },
            {'C',100 },
            {'D',500 },
            {'M',1000 }
        };
            var romanList = new List<string> { "III", "IV", "LVIII", "MCMXCIV" };
            romanList.ForEach(roman =>
            {
                var result = 0;
                var array = roman.ToCharArray();
                for (var i = 0; i <= array.Length - 1; i++)
                {
                    if (i == array.Length - 1)
                    {
                        result += dict[array[i]];
                        break;
                    }
                    var current = array[i];
                    var next = array[i + 1];
                    if (dict[current] < dict[next])
                    {
                        result += -dict[current];
                    }
                    else
                    {
                        result += dict[current];
                    }
                }
                log.Info($"roman number {roman} to integer is {result}");
            });


        }

        [Fact]
        public void LongestCommonPrefix()
        {
            var list = new List<string> { "flower", "flow", "flight" };

        }
    }
}
