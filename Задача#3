using System;
					
public class Program
{
	public static void Main()
	{
			int n;
            Console.WriteLine("Введите число элементов массива");
            n = Convert.ToInt32(Console.ReadLine());
            double[] Data = new double[n];
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("Введите {0}й элемент массива ", i+1);
                Data[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            for (i = 0; i < n; i = i + 1)
                Console.Write(Data[i]+" ");
            int sum = 0;
            Console.WriteLine("\nКратные три:");
            for(i=0;i<n;i++)
                if (Convert.ToInt32(Data[i]) % 3 == 0) { Console.WriteLine("Массив[{0}] = {1} ", i+1, Data[i]); sum++; }
            Console.WriteLine("Всего:" + sum);
	}
}
