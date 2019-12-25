using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class TwoSum: BaseLesson
    {
        protected override int Index { get; set; } = 1;
        protected override string Title { get; set; } =  "两数之和";
        protected override string Desc { get; set; } =  "给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标";
        protected override string Url { get; set; } =  "https://leetcode-cn.com/problems/two-sum/";

        [Param]
        private int[] nums { get; set; } 
        [Param]
        private int target { get; set; }

        public  TwoSum()
        {
            this.nums = new List<int> { 2, 7, 11, 15 }.ToArray();
            this.target = 9;
        }

        public TwoSum(List<int> nums,int target)
        {
            this.nums = nums.ToArray();
            this.target = target;
        }

        public List<int> Simple()
        {
            var result = new List<int>();
            for (var i=0;i<nums.Length;i++)
            {
                for (var j= i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result.AddRange(new List<int> { i, j }); 
                    }
                }
            }
            return result;
        }

        public int[] Simple2()
        {
            var result = new int[2];
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }

        public int[] Simple3()
        {
            var result = new int[2];
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    result = new int[] {i, dict[target-nums[i]]};
                }
                dict[nums[i]] = i;
            }
            return result;
        }

        public override void Action()
        {
            base.BaseAction();
            base.ShowParam(new Dictionary<string, object> { { nameof(nums), nums }, { nameof(target), target } });
            var twoSum = new TwoSum(new List<int> { 2, 7, 11, 15,1,0,22,10,89,12,78,13 },  28);

            var result = twoSum.Simple(); 
            Console.WriteLine($"result:{string.Join(',',result)}");
           var result2 = twoSum.Simple2();
            Console.WriteLine($"result:{string.Join(',', result2)}");
           var result3 = twoSum.Simple3();
            Console.WriteLine($"result:{string.Join(',', result3)}");

        }
    }
}