using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public  class BaseLesson
    {
        public virtual int Index { get; set; }
        public virtual string Title { get; set; }
        public virtual string Desc { get; set; }
        public virtual string Url { get; set; }
    }
}
