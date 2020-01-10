using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Problem
{
    public class ReverseString : BaseLesson
    {
        protected override int Index { get; set; } = 1198;
        protected override string Title { get; set; } = "反转字符串";
        protected override string Desc { get; set; } = "不要给另外的数组分配额外的空间，你必须原地修改输入数组、使用 O(1) 的额外空间解决这一问题";
        protected override string Url { get; set; } = "https://leetcode-cn.com/explore/featured/card/recursion-i/256/principle-of-recursion/1198/";

        public override void Action()
        {
            base.BaseAction();
            var array = "hello".ToCharArray();
            base.ShowParam(new Dictionary<string, object> { { nameof(array), array } });
            var result = Reverse(array);
            var result1 = Reverse1("leetcode".ToCharArray());
        }

        /// <summary>
        /// O(1)算法
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        char[] Reverse1(char[] s)
        {
            Console.WriteLine(string.Join(' ', s));
            var length = s.Length;
            for (var i = 0; i < length / 2; i++)
            { 
                var tmp = s[i];
                s[i] = s[length - 1-i];
                s[length - 1 - i] = tmp; 
            }
            Console.WriteLine(string.Join(' ', s));
            return s;
        }

        /// <summary>
        /// 基本方法
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        char[] Reverse(char[] s)
        {
            var result = new char[s.Length];
            var index = 0;
            for (var i = s.Length - 1; i >= 0; i--)
            {
                result[index] = s[i];
                index++;
            }
            return result;
        }

    }
}
