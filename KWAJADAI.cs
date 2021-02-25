using System;

namespace Kwajadai
{
    class Program
    {
        static void Main(string[] args)
        {
            string Agency;
            double Num1, Num2, Num3, Num4, Num5, Num6, Password;

            Console.Write("Input your password : ");
            Password = double.Parse(Console.ReadLine());

            Console.Write("Input your agency : ");
            Agency = Console.ReadLine();


            if (Agency == "CIA")
            {
                Num1 = Password / 100000;
                Num1 = Math.Floor(Num1);
                Num2 = ((Math.Floor(Password / 10000)) - ((Math.Floor(Password / 100000)) * 10.0));
                Num3 = ((Math.Floor(Password / 1000)) - ((Math.Floor(Password / 10000)) * 10.0));
                Num4 = ((Math.Floor(Password / 100)) - ((Math.Floor(Password / 1000)) * 10.0));
                Num5 = ((Math.Floor(Password / 10)) - ((Math.Floor(Password / 100)) * 10.0));
                Num6 = ((Password) - ((Math.Floor(Password / 10)) * 10));

                if (Num1 >= 0 && Num1 <= 9)
                {
                    if (Num2 >= 0 && Num2 <= 9)
                    {
                        if (Num3 >= 6 && Num3 != 8)
                        {
                            if (Num4 >= 0 && Num4 <= 9)
                            {
                                if (Num5 != 1 && Num5 != 3 && Num5 != 5)
                                {
                                    if (Num6 % 3 == 0)
                                    {
                                        Console.WriteLine("True");
                                    }
                                    else
                                    {
                                        Console.WriteLine("False");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("False");
                                }
                            }
                            else
                            {
                                Console.WriteLine("False");
                            }
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }
            }

            else if (Agency == "FBI")
            {
                Num1 = Password / 100000;
                Num1 = Math.Floor(Num1);
                Num2 = ((Math.Floor(Password / 10000)) - ((Math.Floor(Password / 100000)) * 10.0));
                Num3 = ((Math.Floor(Password / 1000)) - ((Math.Floor(Password / 10000)) * 10.0));
                Num4 = ((Math.Floor(Password / 100)) - ((Math.Floor(Password / 1000)) * 10.0));
                Num5 = ((Math.Floor(Password / 10)) - ((Math.Floor(Password / 100)) * 10.0));
                Num6 = ((Password) - ((Math.Floor(Password / 10)) * 10));

                if (Num1 >= 4 && Num1 <= 7)
                {
                    if (Num2 % 2 != 0)
                    {
                        if (Num3 >= 0 && Num3 <= 9)
                        {
                            if (Num4 % 2 == 0 && Num4 != 6)
                            {
                                if (Num5 >= 0 && Num5 <= 9)
                                {
                                    if (Num6 >= 0 && Num6 <= 9)
                                    {
                                        Console.WriteLine("True");
                                    }
                                    else
                                    {
                                        Console.WriteLine("False");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("False");
                                }
                            }
                            else
                            {
                                Console.WriteLine("False");
                            }
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (Agency == "NSA")
            {
                Num1 = Password / 100000;
                Num1 = Math.Floor(Num1);
                Num2 = ((Math.Floor(Password / 10000)) - ((Math.Floor(Password / 100000)) * 10.0));
                Num3 = ((Math.Floor(Password / 1000)) - ((Math.Floor(Password / 10000)) * 10.0));
                Num4 = ((Math.Floor(Password / 100)) - ((Math.Floor(Password / 1000)) * 10.0));
                Num5 = ((Math.Floor(Password / 10)) - ((Math.Floor(Password / 100)) * 10.0));
                Num6 = ((Password) - ((Math.Floor(Password / 10)) * 10));


                if (Num1 >= 0 && Num1 <= 9)
                {
                    if (Num2 >= 0 && Num2 <= 9)
                    {
                        if (Num3 >= 0 && Num3 <= 9)
                        {
                            if (Num4 == 3 || Num4 == 9)
                            {
                                if ((Num5 >= 0 && Num5 <= 9))
                                {
                                    if (Num6 == 1 || Num6 == 2 || Num6 == 3 || Num6 == 5 || Num6 == 6)
                                    {
                                        if (Num1 == 7 || Num2 == 7 || Num3 == 7 || Num4 == 7)
                                        {
                                            Console.WriteLine("True");
                                        }
                                        else
                                        {
                                            Console.WriteLine("False");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("False");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("False");
                                }
                            }
                            else
                            {
                                Console.WriteLine("False");
                            }
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("False");
            }


            Console.ReadLine();
        }
    }
}
