using System;
using System.Linq;
using System.Collections.Generic;


namespace Transform
{
    public delegate int mapdel(int y);

    public static class Transform 
    {
        public static List<int> Map(this int[] j, mapdel operation)
        {
            List<int> trans = new List<int>();
            foreach (int n in j)
            {
                trans.Add(operation(n));
            }
            return trans;

            //throw new NotImplementedException();
        }
    }
}
