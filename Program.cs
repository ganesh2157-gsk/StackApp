using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<object> stk = new Stack<object>();

            for (int i=0;i<4;i++)
            {
                
                 Console.WriteLine("insert to push:");
                object x = Console.ReadLine();


                if (x == null)
                {
                    Console.WriteLine("null is not allowed");

                }
                else {
                    
                    stk.Push(x);

                }

             }
           
       

                object p=stk.Pop();
                Console.WriteLine("item is removed:{0}",p);

            foreach (object i in stk)
            {
                Console.WriteLine(i);

            }

            stk.Clear();
          
        }
    }

}
