namespace ExceptionsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] num = { 1, 2, 3, };
            //Console.WriteLine(num[10]);


            Console.WriteLine("Next will be catch!+++++++++++++++++++++");
            try   //we want to implement a mechanism that will handle this exception
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                Console.WriteLine(numbers[2]);
                Console.WriteLine(numbers[5]); //this is the exception, out of bounds
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("After catch block");

            Console.WriteLine("+++++++++++++++++++++");

            Console.WriteLine("Next is try catch and final!+++++++++++++++++++++");
            try   
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                Console.WriteLine(numbers[2]);
                Console.WriteLine(numbers[5]); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally 
            {
                Console.WriteLine("Work is done!");
            }


            Console.WriteLine("More than one catch+++++++++++++++++++");
            try   
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                Console.WriteLine(numbers[2]);
                Console.WriteLine(numbers[5]);
                Console.WriteLine(numbers[22]);
            }
            catch (IndexOutOfRangeException indexException)
            {
                Console.WriteLine(indexException.ToString());
            }

        }
    }
}