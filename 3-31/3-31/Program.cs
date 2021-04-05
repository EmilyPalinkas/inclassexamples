using System;

namespace _3_31
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> gpas = new List<double>();
            string answer;

            do
            {
                double gpa = ValidateDoubleInput("Please enter a GPA >>");
                gpas.Add(gpa);


                bool should_contiue
                Console.WriteLine("Do you want to enter more numbers? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            static double ValidateDoubleInput(string message)
            {
                double value;
                string answer;
                do
                {
                    Console.WriteLine(message);
                    answer = Console.ReadLine();


                } while (double.TryParse(answer, out value) == false);



            }

        }
    }
}
