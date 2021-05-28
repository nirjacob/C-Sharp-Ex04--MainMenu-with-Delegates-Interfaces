using System;

namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            TestInterface testInterface = new TestInterface();
            TestDelegate testDelegate = new TestDelegate();
            Program.startInterfaceTest();
            testInterface.Run();
            Program.startDelegateTest();
            testDelegate.Run();

        }
        static private void startInterfaceTest()
        {
            Console.WriteLine("|Starting: Interface Test |");
            Console.WriteLine("|Press Any Key To Continue|");
            Console.ReadKey();
        }
        static private void startDelegateTest()
        {
            Console.WriteLine("|Starting: Delegate Test  |");
            Console.WriteLine("|Press Any Key To Continue|");
            Console.ReadKey();
        }
    }
}
