internal class Program
    {
    private static void Main ( string[] args )
        {
            {
            Console.WriteLine("\n---IPBSES.com---\nSimple Calculator in C# Console\n");
            Console.Write("Please Identify your operator(+ (sum), - (subtract), x (multiply), / (divide)) or 0 to Exit:  ");
            string operation = Console.ReadLine();
            if (!operation.Equals("0"))
                {
                if (operation.Equals("+") || operation.Equals("-") || operation.Equals("x") || operation.Equals("/"))
                    {
                    Console.Write("First Number: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Second Number: ");
                    double b = double.Parse(Console.ReadLine());

                    switch (operation)
                        {
                        case "+":
                            Console.WriteLine("Sum is: " + Sum(a, b));
                            break;
                        case "-":
                            Console.WriteLine("Subtract is: " + Subtract(a, b));
                            break;
                        case "x":
                            Console.WriteLine("Multiplication is: " + Multiply(a, b));
                            break;
                        case "/":
                            Console.WriteLine("Division is: " + Divide(a, b));
                            break;
                        }
                    }
                else
                    {
                    Console.WriteLine("\nPlease only type operators(+ (sum), - (subtract), x (multiply), / (divide)) or 0 to Exit ");

                    }
                }


            }
        Console.ReadKey();

        }
    public static double Sum ( double a, double b )
        {
        return a + b;
        }

    public static double Subtract ( double a, double b )
        {
        return a - b;
        }

    public static double Multiply ( double a, double b )
        {
        return a * b;
        }

    public static double Divide ( double a, double b )
        {
        return a / b;
        }
    }
