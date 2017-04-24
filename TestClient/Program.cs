using System;
using System.Globalization;
using TestClient.RemoteService;

namespace TestClient
{
    class Program
    {
        static void Main()
        {
            var writer = new ConsoleWriter();
            var client = new CalculatorClient(); //http://localhost:55119/Lesson1/Calculator.svc

            try
            {
                writer.Write("Checking connection with the server ... ");
                if (!string.Equals(client.TestConnection(), "OK", StringComparison.InvariantCultureIgnoreCase))
                {
                    throw new Exception("Service is not connected.");
                }
                writer.WriteLineSuccess();
                writer.WriteLine();

                var CheckArithmeticOperation = new Action<Func<double, double, double>, string, double, double, double>
                (
                    (operation, operationName, arg1, arg2, expectedResult) =>
                    {
                        writer.Write("Check the operation '");
                        writer.Write(ConsoleColor.White, operation.Method.Name);
                        writer.Write("', {0} {1} {2} = ", arg1.ToString(CultureInfo.InvariantCulture), operationName,
                            arg2.ToString(CultureInfo.InvariantCulture));
                        var result = operation(arg1, arg2);
                        if (result.Equals(expectedResult))
                        {
                            writer.Write("{0} ", result.ToString(CultureInfo.InvariantCulture));
                            writer.WriteLineSuccess();
                        }
                        else
                        {
                            writer.Write("{0} ", result.ToString(CultureInfo.InvariantCulture));
                            writer.WriteLineError();
                            //                            throw new Exception(
                            //                                $"Error checking method '{operation.Method.Name}': {arg1.ToString(CultureInfo.InvariantCulture)} {operationName} {arg2.ToString(CultureInfo.InvariantCulture)} != {expectedResult.ToString(CultureInfo.InvariantCulture)}");
                        }
                    }
                );

                CheckArithmeticOperation(client.Addition, "+", 2.5, 5, 1.5 + 5);
                CheckArithmeticOperation(client.Subtraction, "-", 2.5, 5, 2.5 - 5);
                CheckArithmeticOperation(client.Multiplication, "*", 2.5, 5, 2.5*5);
                CheckArithmeticOperation(client.Division, "/", 2.5, 5, 2.5/5);
                client.Close();
            }
            catch (Exception ex)
            {
                client.Abort();
                writer.WriteLine();
                writer.WriteLineError("Error: {0}", ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}