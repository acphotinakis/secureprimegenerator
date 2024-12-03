// ########################################################################
// ### Author: Andrew Photinakis                                        ###
// ### File: Program.cs                                                 ###
// ### Description: Main application to generate prime numbers with     ###
// ### custom exception handling for input errors. Includes logic for   ###
// ### generating prime numbers based on user-defined bit length and    ###
// ### count, with error handling and usage instructions.               ###
// ########################################################################

using System.Diagnostics;
using System.Numerics;
using ExtensionMethod;

namespace MainApplication
{

    /// <summary>
    /// Custom exception class for internal input errors in the MainApplication.
    /// </summary>
    public class InternalInputErrorException : Exception
    {
        public InternalInputErrorException()
        {
        }

        public InternalInputErrorException(string message) : base(message)
        {
        }

        public InternalInputErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Displays an error message with usage instructions.
        /// </summary>
        /// <param name="message">The error message to display.</param>
        public static void PrintErrorMessage(string message)
        {
            Console.WriteLine("dotnet run <bits> <count=1>");
            Console.WriteLine("    - bits - the number of bits of the prime number, this must be a");
            Console.WriteLine("      multiple of 8, and at least 32 bits.");
            Console.WriteLine("    - count - the number of prime numbers to generate, defaults to 1");
            Console.WriteLine($"\nInternal Error Message: {message}");
        }
    }

    /// <summary>
    /// Contains the main program logic for generating prime numbers.
    /// Each of the if-statements contains a personal error message based 
    /// user input. The error message based on the criteria of the failed 
    /// input is then used in the exception class above to precisely 
    /// display the error message AFTER the required help message.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            string error;
            try
            {
                if (args.Length < 1)
                {
                    error = "Usage: PrimeGen <bits> [<count=1>]";
                    throw new InternalInputErrorException(error);
                }

                if (args.Length > 2)
                {
                    error = "Too many arguments. Usage: PrimeGen <bits> [<count=1>]";
                    throw new InternalInputErrorException(error);
                }

                if (!int.TryParse(args[0], out int bits) || bits % 8 != 0 || bits < 32)
                {
                    error = "Invalid bits. It must be an integer, a multiple of 8, and at least 32 bits.";
                    throw new InternalInputErrorException(error);
                }

                int count = 1;
                if (args.Length == 2 && (!int.TryParse(args[1], out count) || count <= 0))
                {
                    error = "Invalid count. It must be a positive integer and at least 1";
                    throw new InternalInputErrorException(error);
                }

                // Load 10,000 first prime numbers for use when generating prime numbers.
                // Used as a form of logic preprocessing to cut down time when dealing
                // with large prime numbers.
                PrimeExtension.GeneratePrimesNaive(10000);

                Console.WriteLine($"BitLength: {bits} bits");
                Stopwatch sw = Stopwatch.StartNew();

                // Loop that iterates through count and creates a prime number for each count
                for (int i = 0; i < count; i++)
                {
                    BigInteger prime = PrimeExtension.GeneratePrime(bits, k: 10);

                    if (i + 1 == count)
                    {
                        Console.WriteLine($"{i + 1}: {prime}");
                    }
                    else
                    {
                        Console.WriteLine($"{i + 1}: {prime}\n");
                    }
                }
                sw.Stop();
                Console.WriteLine($"Time to Generate: {sw.Elapsed:g}");
            }
            catch (InternalInputErrorException ex)
            {
                InternalInputErrorException.PrintErrorMessage(ex.Message);
            }
        }
    }


}