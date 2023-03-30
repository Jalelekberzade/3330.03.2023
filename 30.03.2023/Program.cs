using System;

namespace _30._03._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***********************TASK1***********************
            //Console.WriteLine("Soz daxil edin:");
            //string password = Console.ReadLine();
            //Abc(password);



            //***********************TASK2***********************
            //Console.WriteLine("Shifre daxil edin");
            //string password = Console.ReadLine();
            //First(password);




            //***********************TASK3***********************
            //Sumarr();



            //***********************TASK4***********************
            //DublicatArr();


            //***********************TASK5***********************
            /* int[] array =*/ /*Arr();*/
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}



            //***********************TASK6***********************


        }
        static void Abc(string password)
        {
            char[] strArr = { 'A', 'B', 'C', 'D', 'E' };

            bool test = false;
            for (int i = 0; i < strArr.Length; i++)
            {
                if (password[0] == strArr[i])
                {
                    test = true;

                }

            }
            Console.WriteLine(test);
        }


        static void First(string password)
        {
            bool test = false;
            string passwordcopy = password.ToUpper();
            if (password[0] == passwordcopy[0])
            {
                test = true;
            }
            Console.WriteLine(test);    
        }


        static void Sumarr()
        {
            int sum = 0;
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, };
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }
            Console.WriteLine(sum);
        }

        static void DublicatArr()
        {
            int[] ints = { 1, 2, 3, 2, 5, 6, 5 };
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (ints[i] == ints[j])
                    {
                        ints[i] = default;
                    }
                }
                Console.WriteLine(ints[i]);
            }

        }

        static void Arr( )
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7};
            int[] intscopy = new int[ints.Length + 1];
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = ints.Length - 1; j >= 0; j--)
                {
                    intscopy[i] = ints[j];

                    Console.WriteLine(intscopy[i]);
                    break;
                }

            }
         
            
        }

        static 
    }
}

