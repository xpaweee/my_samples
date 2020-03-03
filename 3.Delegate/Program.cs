using System;

namespace _3.Delegate
{
    class Program
    {
        //1
        public delegate void ShowDel();
        static void Main(string[] args)
        {
            //1
            ShowDel name = Show;
            name.Invoke();

            A a = new A();
            a.SomeMethod(CallBackMethod);
            Console.ReadKey();

        }

        static void Show()
        {
            System.Console.WriteLine("Test");
        }

        static void CallBackMethod(int i)
        {
            System.Console.WriteLine(i);
        }
    }

    class A
    {
        public delegate void CallBack(int i);
        public void SomeMethod(CallBack obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                obj(i);
            } 
        }
    }
}
