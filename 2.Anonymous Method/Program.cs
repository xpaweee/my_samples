using System;

namespace _2.Anonymous_Method
{
    class Program
    {
        delegate int PointToAddMethod(int a, int b);
        static void Main(string[] args)
        {
            PointToAddMethod pointAdd = delegate (int a, int b)
            {
                return a+b;
            };
            var tst = pointAdd.Invoke(2,3);
        }

    }
}
