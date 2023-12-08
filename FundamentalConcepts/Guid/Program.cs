using System;

namespace GuidProject
{
    class Program
    {
        static void Main(string[] args)
        {
             //Global Unique Identifier
           var id = Guid.NewGuid();

           Console.WriteLine(id);
        }
    }
}