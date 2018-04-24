// The namespaces we import to our program
using System;

// The namespace we put our program in
namespace TestProjectForGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.PrintSomething();
        }

        private void PrintSomething()
        {
            Console.WriteLine("I'm a test for git tags");
            Console.WriteLine("Tags are a good way to remember versions");
            Console.ReadKey();
        }
    }
}
