using System.Collections.Generic;

namespace LeetCode
{
    public class Lesson1: BaseLesson
    { 
        public override int Index => 1;
        public override string Title => "����֮��";
        public override string Desc => "����һ���������� nums ��һ��Ŀ��ֵ target�������ڸ��������ҳ���ΪĿ��ֵ���� ���� ���������������ǵ������±�";
        public override string Url => "https://leetcode-cn.com/problems/two-sum/";

        private int[] nums { get; set; }

        public Lesson1(List<int> nums)
        {
            this.nums = nums.ToArray();
        }


    }
}