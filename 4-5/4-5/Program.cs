using System;

namespace _4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Please input your grade in the course >>");
                double grade = Convert.ToDouble(Console.ReadLine());

                string lg = ConvertGradeToLetterGrade(grade);

                Console.WriteLine($"Congrats you have an {lg} in the course!");

                Console.WriteLine("Do you want to convert another grade? yes or no >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');
        }

       
        /// <summary>
        /// Converts standard grade(e.g. 98.5) to the appropriate Letter Grade (e.g. A)
        /// </summary>
        /// <param name="anyVariableNameWeWantThisToBekongToThisMethod">The grade to convert to a letter grade</param>
        /// <returns>A string that is the letter grade of the input. N/A if ti is below 0</returns>
        static string ConvertGradeToLetterGrade(double anyVariableNameWeWantThisToBekongToThisMethod)
        {
            string letterGrade;
            if (anyVariableNameWeWantThisToBekongToThisMethod >=90)
            {
                letterGrade = "A";
            }
            else if (anyVariableNameWeWantThisToBekongToThisMethod >= 80)
            {
                letterGrade = "B";
            }
            else if (anyVariableNameWeWantThisToBekongToThisMethod >= 70)
            {
                letterGrade = "C";
            }
            else if (anyVariableNameWeWantThisToBekongToThisMethod >= 60)
            {
                letterGrade = "D";
            }
            else if (anyVariableNameWeWantThisToBekongToThisMethod >= 0)
            {
                letterGrade = "F";
            }
            else
            {
                letterGrade = "N/A";
            }

            return letterGrade;
        }
    }
}
