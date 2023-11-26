namespace Sana03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            double[] array = new double[number];
            double negativesum = 0;
            double min = 11;
            double max = -11;
            double maxindex = 0;
            double maxmodule = 0;
            int indexsum = 0;
            int count = 0;
            for(int index = 0;index < number; index++)
            {
                double randomnumber = random.NextDouble() * 20 - 10 ;
                string convert = randomnumber.ToString("F2");
                double converttwo = double.Parse(convert);
                array[index] = converttwo;
                Console.Write($" {array[index]}");
                if (array[index] < 0) { negativesum = negativesum + array[index]; }
                if (array[index] < min) { min = array[index]; }
                if (array[index] > max) { max = array[index]; maxindex = index; }
                if (Math.Abs(array[index]) > max){ maxmodule = array[index]; }
                if (array[index] > 0) { indexsum = indexsum + index; }
                if (array[index] % 1 == 0 ){ count = count + 1; }
            }
            Console.WriteLine($"\nSum of negative elements = {negativesum}");
            Console.WriteLine($"The minimun element = {min}");
            Console.WriteLine($"The index of the max element = {maxindex}");
            Console.WriteLine($"Max module element = {maxmodule}");
            Console.WriteLine($"Sum of indexes of positive elements  = {indexsum}");
            Console.WriteLine($"Sum of integers = {count}");
        }
    }
}