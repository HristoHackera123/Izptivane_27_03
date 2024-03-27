namespace Izpitvane27._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = InputGrades(); //1
            Console.WriteLine($"Моята оценка: {grades[23]}");  //2
            Find2(grades); //3
            Console.WriteLine($"Последният елемент е: {grades.Length}-ти на индекс {grades.Length-1}"); //4
            Console.WriteLine($"Оценките, по малки от моята, са: {string.Join(" ", FindLowerGrade(grades))}"); //5
            Console.WriteLine($"Броят на оценките, по-големи от моята, са: {FindNumberOfHigherGrades(grades)}"); //6
            Console.WriteLine($"Средно аретмитичното на двете оценки по средата е {AvgOfArrayMiddle(grades)}"); //7
            Console.WriteLine($"Оценката ми сега е 6 вместо {grades[23]}"); //8
            grades[23] = 6;
            Console.Write("My name is: "); //9
            string MyName = Console.ReadLine();
            Console.Write("Censored version: ");
            Console.WriteLine(MyName.Replace('i', '#'));
        }
        static int[] InputGrades()
        {
            int[] input = new int[26]; 
            for (int i = 0; i <= 12; i++)
            {
                Console.Write($"Оценка на {i+1} номер: ");
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.Write($"Оценка на 24 номер: ");
            input[23] = int.Parse(Console.ReadLine());
            return input;
        }
        static void Find2(int[] grades)
        {
            for (int i = 0;i < grades.Length; i++)
            {
                if (grades[i] == 2)
                {
                    Console.WriteLine($"{i+1}ти номер ({i} индекс) има 2");
                }
            }
        }
        static List<int> FindLowerGrade(int[] grades)
        {
            List<int> result = new List<int>();
            int myGrade = grades[23];
            for (int i = 0; i < grades.Length-1; i++)
            {
                if (myGrade > grades[i])
                {
                    result.Add(grades[i]);
                }
            }
            return result;
        }
        static int FindNumberOfHigherGrades(int[] grades)
        {
            int result = 0;
            int myGrade = grades[23];
            for (int i = 0; i < grades.Length - 1; i++)
            {
                if (myGrade < grades[i])
                {
                    result++;
                }
            }
            return result;
        }
        static double AvgOfArrayMiddle(int[] grades)
        {
            int middle1 = grades.Length / 2 - 1;
            int middle2 = middle1+ 1;
            double avg = (grades[middle1] + grades[middle2]) / 2;
            return avg;
        }
    }
}
