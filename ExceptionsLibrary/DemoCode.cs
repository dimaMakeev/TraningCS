using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLibrary
{
    public class DemoCode
    {

        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }

        public int GrandPerentMethod(int position)
        {
            return ParentMethod(position);
        }

        public int GetNumber(int position)
        {
            int[] numbers = new int[] { 1, 4, 7, 2 };
            return numbers[position];
        }
    }
}
