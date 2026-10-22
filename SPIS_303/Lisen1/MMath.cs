using Leason1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subjects
{
    public class MMath: Leason1.Math
    {
        void test1()
        {
            Sum(1, 2);
        }
        protected int count(int[] elementArray)
        {
            return elementArray.Count();
        }
    }
}
