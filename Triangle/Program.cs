using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static Boolean isContinue = true;
        static void Main(string[] args)
        {
            Console.WriteLine("TRIANGLE CALCULATOR");
            Console.WriteLine("***************************");
            Console.WriteLine("1. CALCULATE");
            Console.WriteLine("2. EXIT");

            while (isContinue)
            {
                Console.Write("ENTER CHOICE # : ");

                int choiceEntered = 0;
                Boolean validInput = int.TryParse(Console.ReadLine(), out choiceEntered);

                if (validInput)
                {
                    if (choiceEntered == 1)
                    {
                        int[] triangleSides = new int[3];
                        int Tside;

                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("PLEASE ENTER SIDE: ");
                            Boolean validSideInput = int.TryParse(Console.ReadLine(), out Tside);

                            if (validSideInput)
                                triangleSides[i] = Tside;
                            else
                            {
                                Console.WriteLine("INVALID INPUT\n");
                                i--;
                            }
                        }

                        String triangleType = TriangleSolver.Analyze(triangleSides[0], triangleSides[1], triangleSides[2]);
                        Console.WriteLine(triangleType + "\n");
                    }
                    else if (choiceEntered == 2)
                    {
                        isContinue = false;
                        Environment.Exit(0); //EXIT ENVIRONMENT
                    }
                    else
                    {
                        Console.WriteLine("INVALID CHOICE \n");
                    }
                }
                else
                {
                    Console.WriteLine("INVALID CHOICE \n");
                }
            }
        }
    }
}
