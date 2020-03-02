using System;

namespace _1.Func_Action_Predicate
{
    class Program
    {
        //1
        delegate double CalculateArePointer(double r);
        static CalculateArePointer cpointer = CalculateArea;
        
        static double CalculateArea(double r)
        {
            return Math.PI * r * r;
        }

        static void Main(string[] args)
        {
            //1.
            double area = cpointer.Invoke(20);
            System.Console.WriteLine(area);

            //2
            CalculateArePointer cpointer2 = new CalculateArePointer(
                                            delegate(double r)
                                            {
                                                return Math.PI * r * r;
                                            });
            double area2 = cpointer(20);

            //3
            CalculateArePointer cpointer3 = r => Math.PI * r * r;
            double area3 = cpointer3(20);

            //4 - jednolinijkowy zapis delegaty
            Func<double,double> cpointer4 = r => Math.PI * r * r;
            double area4 = cpointer4(20);

            //Action - nic nie zwróci 
            Action<string> MyAction = s => System.Console.WriteLine("Hejka");
        }

    }
}
