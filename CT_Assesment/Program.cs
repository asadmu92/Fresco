using System;
using System.Collections.Generic;

namespace CT_Assesment
{
    class Program
    {
        static void Main(string[] args)
        {
            // three types of trolley declared
            Dictionary<int, string> FullSizeTrolleys = new Dictionary<int, string>();
            Dictionary<int, string> HalfSizeTrolleys = new Dictionary<int, string>();
            Dictionary<int, string> WheeledBasket = new Dictionary<int, string>();

            // variables decalared to be used inside the do while loop
            int opt, key;
            string ch, customerName;

            do
            {
                //App Menu
                Console.WriteLine("===========FRESCO APP================");
                Console.WriteLine("1. Issue a Trolley");
                Console.WriteLine("2. Return a Trolley");
                Console.WriteLine("3. Total Trolleys Loaned Each Type");
                Console.WriteLine("4. Total Trolleys Loaned ");
                Console.WriteLine("5. Total Trolleys not on Loaned Each Type");
                Console.WriteLine("6. Total Trolleys not on Loaned ");
                Console.WriteLine("7. Find out Common and Least Common Trolley type");
                Console.WriteLine("=====================================\n");

                // Taking User input for option
                Console.Write("Enter Operation:");
                opt = int.Parse(Console.ReadLine());

                // Issue Trolley Code Starts
                if (opt == 1)
                {
                    Console.WriteLine("1. Full Size Trolley ");
                    Console.WriteLine("2. Half Size Trolley ");
                    Console.WriteLine("3. Wheel Basket");

                    Console.Write("Enter Operation for Selecting Trolley:");
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.Write("Enter Trolley Code:");
                        key = int.Parse(Console.ReadLine());

                        if (key >= 1001 && key <= 1030)
                        {
                            if (FullSizeTrolleys.ContainsKey(key))
                            {
                                Console.WriteLine("Already Issued!");
                            }
                            else
                            {
                                Console.Write("Enter Customer Name:");
                                customerName = Console.ReadLine();
                                FullSizeTrolleys.Add(key, customerName);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Trolley Number");
                        }

                    }
                    //issue trolley code ends

                    // return trolley code starts
                    else if (op == 2)
                    {
                        Console.Write("Enter Trolley Code:");
                        key = int.Parse(Console.ReadLine());

                        if (key >= 2001 && key <= 2020)
                        {
                            if (FullSizeTrolleys.ContainsKey(key))
                            {
                                Console.WriteLine("Already Issued!");
                            }
                            else
                            {
                                Console.Write("Enter Customer Name:");
                                customerName = Console.ReadLine();
                                HalfSizeTrolleys.Add(key, customerName);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Trolley Number");
                        }
                    }
                    else if (op == 3)
                    {
                        Console.Write("Enter Basket Code:");
                        key = int.Parse(Console.ReadLine());

                        if (key >= 3001 && key <= 3025)
                        {
                            if (FullSizeTrolleys.ContainsKey(key))
                            {
                                Console.WriteLine("Already Issued!");
                            }
                            else
                            {
                                Console.Write("Enter Customer Name:");
                                customerName = Console.ReadLine();
                                WheeledBasket.Add(key, customerName);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Trolley Number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Option Selected");
                    }
                }
                else if (opt == 2)
                {
                    Console.WriteLine("Enter Which Trolley to return");
                    Console.WriteLine("1. Full Size Trolley ");
                    Console.WriteLine("2. Half Size Trolley ");
                    Console.WriteLine("3. Wheel Basket");

                    Console.Write("Enter Operation for Return Trolley:");
                    int op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        Console.Write("Enter Trolley Code:");
                        key = int.Parse(Console.ReadLine());

                        if (FullSizeTrolleys.ContainsKey(key))
                        {
                            FullSizeTrolleys.Remove(key);
                        }
                        else
                        {
                            Console.WriteLine("Wrong Trolley Code Entered");
                        }
                    }
                    else if (op == 2)
                    {
                        Console.Write("Enter Trolley Code:");
                        key = int.Parse(Console.ReadLine());

                        if (HalfSizeTrolleys.ContainsKey(key))
                        {
                            HalfSizeTrolleys.Remove(key);
                        }
                        else
                        {
                            Console.WriteLine("Wrong Trolley Code Entered");
                        }
                    }
                    else if (op == 3)
                    {
                        Console.Write("Enter Trolley Code:");
                        key = int.Parse(Console.ReadLine());

                        if (WheeledBasket.ContainsKey(key))
                        {
                            WheeledBasket.Remove(key);
                        }
                        else
                        {
                            Console.WriteLine("Wrong Trolley Code Entered");
                        }
                    }
                }
                // return trolley code starts

                //Each trolley details code starts
                else if (opt == 3)
                {
                    Console.WriteLine("==========Details of Each Trolley Type on Loaned===========\n");
                    Console.WriteLine("Full Size Trolley on Loaned:" + FullSizeTrolleys.Count);
                    Console.WriteLine("Half Size Trolley on Loaned:" + HalfSizeTrolleys.Count);
                    Console.WriteLine("Wheel Basket Trolley on Loaned:" + WheeledBasket.Count);
                    Console.WriteLine("=====================");
                }
                //Each trolley details code ends

                // Details of Trolley on Loan code starts
                else if (opt == 4)
                {
                    Console.WriteLine("==========Details of Trolley on Loaned===========\n");
                    Console.WriteLine("Total Trolley on Loaned:" + (FullSizeTrolleys.Count + HalfSizeTrolleys.Count + WheeledBasket.Count));
                    Console.WriteLine("=====================");


                }
                // Details of Trolley on Loan code ends

                // Details of each Trolley type not on Loan code starts
                else if (opt == 5)
                {
                    Console.WriteLine("==========Details of Each Trolley Type Not on Loaned===========\n");
                    Console.WriteLine("Full Size Trolley not on Loaned:" + (30 - FullSizeTrolleys.Count));
                    Console.WriteLine("Half Size Trolley not on Loaned:" + (20 - HalfSizeTrolleys.Count));
                    Console.WriteLine("Wheel Basket Trolley not on Loaned:" + (25 - WheeledBasket.Count));
                    Console.WriteLine("=====================");
                }

                // Details of each Trolley type on Loan code ends

                //Details of Trolley not on Loan code starts
                else if (opt == 6)
                {
                    Console.WriteLine("==========Details of Trolley on Loaned===========\n");
                    Console.WriteLine("Total Trolley not on Loaned:" + (75 - (FullSizeTrolleys.Count + HalfSizeTrolleys.Count + WheeledBasket.Count)));
                    Console.WriteLine("=====================");

                }
                //Details of Trolley not on Loan code ends

                else if (opt == 7)
                {
                    // code of least commmon and common trolley type here
                    int fCount = FullSizeTrolleys.Count;
                    int hCount = HalfSizeTrolleys.Count;
                    int wCount = WheeledBasket.Count;

                    if(fCount==0 && hCount==0 && wCount==0)
                    {
                        Console.WriteLine("No Trolley issue so cant tell which one is Least or commonly used");
                    }
                    else if(fCount>hCount)
                    {
                        if(fCount>wCount)
                        {
                            Console.WriteLine("FullSize Trolley are Mostly Used by Customers");
                        }
                    }
                    else if (hCount> fCount)
                    {
                        if (hCount > wCount)
                        {
                            Console.WriteLine("HalfSize Trolley are Mostly Used by Customers");
                        }
                    }
                    else if (wCount > fCount)
                    {
                        if (wCount > hCount)
                        {
                            Console.WriteLine("Wheeled Basket are Mostly Used by Customers");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Operation!");
                }

                Console.Write("Do you want perform more operations Press Y for Continue and N for Exit: ");
                ch = Console.ReadLine();
            } while (ch == "Y" || ch == "y");

            Console.ReadKey();
        }
    }
}
