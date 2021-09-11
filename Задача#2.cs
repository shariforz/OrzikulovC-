using System;
					
public class Program
{
	public static void Main()
	{
	string name1;
    	Console.Write("\n\n");
   	Console.Write("Введите имя : ");
   	name1 = Console.ReadLine();		
    	if (name1 == "Вячеслав")
 		Console.WriteLine("Привет {0}\n", name1);
    	else
 		Console.WriteLine("Нет такого имени\n");
	}
}
