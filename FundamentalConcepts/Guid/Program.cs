using System;

namespace GuidProject
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Global Unique Identifier
           var id = Guid.NewGuid();

           id = new Guid("f5b5e5e0-0b7e-4e1e-8e0e-5b1a0d0c0b0a");

           id = new Guid();

           Console.WriteLine(id);
           //if(id == Guid.NewGuid())
           //    Console.WriteLine(id.ToString().Substring(0,8));

        }
    }
}