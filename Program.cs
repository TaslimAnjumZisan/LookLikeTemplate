using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace LookLikeTemplate
{
    internal class Program
    {

        class Demo
        {
            //    public static void array(int [] arr)
            //    {
            //        for(int i=0;i<arr.Length; i++)
            //        {
            //            Console.WriteLine(arr[i]);
            //        }
            //    }

            //    public static void array(string[] arr)
            //    {
            //        for (int i = 0; i < arr.Length; i++)
            //        {
            //            Console.WriteLine(arr[i]);
            //        }
            //    }

            //Generic Method
            public static void array<T>(T[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                
            }

            public static void Number<T>(T[] arr)
            {

            }

            //public static bool check(int a, int b)
            //{
            //    bool c= a.Equals(b);
            //    return c;
            //}

            public static bool check<t>(t a, t b)
            {
                bool c = a.Equals(b);
                return c;
            }
        }

        //class Demo2
        //{
        //    int value;
        //    public Demo2(int v)
        //    {
        //        this.value = v;
        //    }
        //    public int getValu()
        //    {
        //        return this.value;
        //    }
        //}


        //class
        class Demo2<T>
        {
            T value;

            public Demo2()
            {
               
            }
            public Demo2(T v)
            {
                this.value = v;
            }
            public T getValu()
            {
                return this.value;
            }

            //generic property
            public T VaLUE
            {
                get 
                { 
                    return this.value; 
                }
                set
                { 
                    this.value = value; 
                }
            }
        }


        static void Main(string[] args)
        {
            int[] number = new int[3];
            number[0] = 10;
            number[1] = 20;
            number[2] = 30;

            Demo.array(number);


            string[] name = { "Dr.", "Cecilia", "Hasan" };
            double[] price = { 100.20, 200.2, 130.4 };


            Demo.array(name);
            Demo.array(price);
            

            Console.WriteLine(Demo.check(10,20));
            Console.WriteLine(Demo.check(20,20));

            Console.WriteLine(Demo.check("aLi","ali"));


            //Demo2 classD = new Demo2(50);
            //Demo2 classD2 = new Demo2("Cecilia");

            //Console.Clear();
            Demo2<int> classD1 = new Demo2<int>(50);
            Demo2<string> classD2 = new Demo2<string>("Cecilia");
            Demo2<char> classD3 = new Demo2<char>('G');

            Console.WriteLine(classD1.getValu());
            Console.WriteLine(classD2.getValu());
            Console.WriteLine(classD3.getValu());

            Demo2<double> classD4 = new Demo2<double>();
            classD4.VaLUE = 100;
            Console.WriteLine(classD4.getValu());

            //Demo2<string> classD5 = new Demo2<string>();
            //classD5.VaLUE = "Set Get Property";
            //Console.WriteLine(classD5.getValu());

            //Demo2 <double> classD6 = new Demo2<double>(200.5);
            //Console.WriteLine(classD6.getValu());
        }
    }
}

//Generic

//#Definition
//->Genaral form , not Specific to a particular (Data type)
//->Class, Interface, abstract Class Fields, Methods, Properties, Events Delegate, Operator

//# Syntax
//TypeName <T> //Place holder, type parameter
//TypeName <M> //Place holder, type parameter
//TypeName <T, M> //Place holder, type parameter

//# using System.Collection.Generic;
//Collection, List, Queue, Stack, Dictionary

//#advantages
//Reusability, TypeSafty, Performance