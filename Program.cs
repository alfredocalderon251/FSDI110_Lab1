using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            new Program(); //Creating an instance 
        }


//Constructor
//- It must have the same name as the class
// - Is the only method that DO NOT contain return type
        public Program(){
            Console.WriteLine("My First DotNet app");
        }

        void Test(){

            int age=99;
            
            float gravity=9.8f;
            decimal money=12.99m;
            bool isThisCrazy=true;

            string text="This is an String";

            System.Console.WriteLine("This is my name: Alfredo");

            if(money<50){
                System.Console.WriteLine("Its cheap");
            }
            else{
                System.Console.WriteLine("Its expensive");
            }

            for(int i=0;i<9;i++){
                System.Console.WriteLine("Iteration: "+i);
            }

        }

        /**
        Method (function)
        -access level (optional, default is private)
        -return type (always return a value of that type)
        -Name
        -Parameters (type name, type name)
        */
        public int SayHello(){
            Console.WriteLine("I'am a Method");

            bool isRainny=false;
            if(isRainny){
                return 21;
            }
            else{
                return 6;
            }

            //return 1;
        }
    }
}
