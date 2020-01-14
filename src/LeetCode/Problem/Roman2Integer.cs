using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem
{
    public class Roman2Integer : BaseLesson
    {
        protected override int Index { get; set; } = 1;
        protected override string Title { get; set; } = "罗马数字转整数";
        protected override string Desc { get; set; } = "罗马字符I， V， X， L，C，D 和 M转换成对应的字符1,5,10,50,100,500,1000";
        protected override string Url { get; set; } = "https://leetcode-cn.com/problems/roman-to-integer/";

        private Dictionary<char, int> dict = new Dictionary<char, int> {
            {'I',1 },
            {'V',5 },
            {'X',10 },
            {'L',50 },
            {'C',100 },
            {'D',500 },
            {'M',1000 }
        };

        public override void Action()
        {
            var romanList = new List<string> { "III","IV", "LVIII", "MCMXCIV" };
            romanList.ForEach(roman =>
            {
                var num = RomanToInt(roman);
                log.Info($"roman number {roman} to integer is {num}");
            }); 
        }

        public int RomanToInt(string s)
        {
            var result = 0;
            var array = s.ToCharArray();
            for (var i = 0; i <= array.Length - 1; i++)
            {
                if (i == array.Length - 1) {
                    break;
                }
                if (dict[array[i]] >= dict[array[i + 1]])//左边比右边大+
                {
                    result += dict[array[i]] + dict[array[i + 1]];
                }
                else//左边比右边小-
                {
                    result += dict[array[i + 1]] - dict[array[i]];
                }
            }
            return result;
        }

    }
}
