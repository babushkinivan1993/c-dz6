// Task41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// int Count(int m)
// {
//     int result = 0;
//     for(int i=1; i<=m; i++)
//     {
//         Console.WriteLine($"Please enetr the {i} number");
//         int number = Convert.ToInt32(Console.ReadLine());
//         if (number>0) result=result+1;
//     }
//     return result;
// }
// Console.Write("Please tell me how many number do you want to enter _ ");
// int m = Convert.ToInt32(Console.ReadLine());
// int polozhit = Count(m);
// Console.WriteLine("In you numbers are " + polozhit + " numbers over the 0");

// Task43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// double Xperesech(double k1,double b1,double k2,double b2)
// {
// double x = 0;
// x = (b2-b1)/(k1-k2);
// return x;
// }
// double Yperesech(double k1, double b1,double x)
// {
//     double y = 0;
//     y = k1*x+b1;
//     return y;
// }

// Console.WriteLine("Please eneter the number of k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please eneter the number of b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please eneter the number of k2");
// double k2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please eneter the number of b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// double x = Xperesech(k1, b1, k2, b2);
// double y = Yperesech(k1, b1, x);
// Console.WriteLine($"Tochka peresecheniya - ({x} ; {y})");