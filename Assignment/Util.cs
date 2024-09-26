using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public static class Util
    {
        #region Part02
        public static void Reverse(ArrayList list)
        {
            if (list == null || list.Count == 0)
            {
                return;
            }

            int n = list.Count;

            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                if (list[i] is int)
                {
                    object temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }

        public static List<int> GetEven(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                return null;
            }

            List<int> evenList = new List<int>();

            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    evenList.Add(i);
                }
            }

            return evenList;
        }
        #endregion
    }
}
