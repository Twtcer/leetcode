using System.Collections.Generic;

namespace LeetCode
{
    public class Lesson1: BaseLesson
    { 
        public override int Index => 1;
        public override string Title => "两数之和";
        public override string Desc => "给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标";
        public override string Url => "https://leetcode-cn.com/problems/two-sum/";

        private int[] nums { get; set; }

        public Lesson1(List<int> nums)
        {
            this.nums = nums.ToArray();
        }


    }
}