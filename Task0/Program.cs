using static System.Console;

WriteLine("Введите число: ");

int a= int.Parse(ReadLine()!); //   int a=(ReadLine().Прога чтоб преобразовать после знака = в int , нужно написать int.Parse(ReadLine())/ 
//Но Parse работает только со строкой//
//int b = Convert.ToInt32(ReadLine());
WriteLine($"Квадрат числа {a}равен {a*a}");
