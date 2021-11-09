// Почувствуй себя интерном
//  0. ======Вывести квадрат числа=======

// int Func(int x)
// {
//     return x * x;
// }
// int res = Func(5);
// Console.WriteLine(res);

//  1. По двум заданным числам проверять является ли первое квадратом второго

// bool Func1(int x, int y)
// {
//     return x == y * y;
// }
// Console.WriteLine(Func1(25, 5));

//  2. Даны два числа. Показать большее и меньшее число

// int CreateNum()
// {
//     return new Random().Next(1, 100);
// }

// int a = CreateNum();
// int b = CreateNum();

// int Max(int first, int second)
// {
//     if (first > second) return first;
//     else return second;
// }

// int Min(int fir, int sec)
// {
//     if (fir < sec) return fir;
//     else return sec;
// }

// int high = Max(a, b);
// int low = Min(a, b);

// Console.WriteLine($"Большее число {high}");
// Console.WriteLine($"Меньшее число {low}");
// __________________
// //верхние методы сокращаются до показаных снизу, которые можно соединить в один
// int Max2(int first, int second) => first > second ? first : second;
// int Min2(int fir, int sec) => fir < sec ? fir : sec;

// (int min, int max) MinMax(int f, int s) => f > s ? (f, s) : (s, f);

//  3. =======По заданному номеру дня недели вывести его название=======

// string Func(int x)
// {
//     string [] array = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
//     return array[x - 1]; 
// }
// Console.WriteLine(Func(4));

//  4. Найти максимальное из трех чисел

// int FindMaxNumber(int x, int y, int z)
// {
//     int max = x;
//     if(y > max) max = y;
//     if(z > max) max = z;
//     return max;
// }

// int CreateNum()
// {
//     return new Random().Next(1, 100);
// }

// int a = CreateNum();
// Console.Write($"{a} ");
// int b = CreateNum();
// Console.Write($"{b} ");
// int c = CreateNum();
// Console.WriteLine(c);

// int ans = FindMaxNumber(a, b, c);
// Console.WriteLine($"Максимальное число {ans}");

//  5. Написать программу вычисления значения функции y=f(a)

// double F(double a)
// {
//     return Math.Sin (a);
// }
// double sin = F(2);
// Console.Write(sin);

//  6. =======Выяснить является ли число чётным========

// bool Func(int a)
// {
//     return a % 2 == 0;
// }
// Console.WriteLine(Func(6));

//  7. =======Показать числа от -N до N========

// int [] arrayA = new int [10];

// int[] CreateArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 11);
//     }
//     return array;
// }

// CreateArray(arrayA);

// for(int count = 0; count < arrayA.Length; count++) Console.Write($"{arrayA[count]} ");

//  8. =========Показать четные числа от 1 до N=========

// int [] arrayA = new int [10];
// int n = 21;

// int [] CreateArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, n + 1);
//     }
//     return array;
// }

// CreateArray(arrayA);

// for(int ind = 0; ind < arrayA.Length; ind++) Console.Write($"{arrayA[ind]} ");

// Console.WriteLine();

// for(int index = 0; index < arrayA.Length; index++)
// {
//     if(arrayA[index] % 2 == 0) Console.Write($"{arrayA[index]} ");
// }    

//  9. =====Показать последнюю цифру трёхзначного числа======

// int LastNumber(int arg)
// {
//     return arg % 10;
// }
// int ans = LastNumber(349);
// Console.WriteLine(ans);

// 10. =========Показать вторую цифру трёхзначного числа========

// int SecNumber(int arg)
// {
//     return arg / 10 % 10;
// }
// int ans = SecNumber(973);
// Console.WriteLine(ans);

// 11. =========Дано число из отрезка [10, 99]. Показать наибольшую цифру числа=======

// int MaxNum(int arg)
// {
//     int a = arg / 10;
//     int b = arg % 10;
//     if(a > b) return a;
//     else return b;
// }

// int CreateNum()
// {
//     return new Random().Next(10, 100);
// }

// int number = CreateNum();
// Console.WriteLine(number);
// Console.WriteLine(MaxNum(number));

// 12. ======Удалить вторую цифру трёхзначного числа=========

// int DeleteSecNumber(int arg)
// {
//     int a = arg / 100;
//     int b = arg % 10;
//     return a * 10 + b;
// }

// int ans = DeleteSecNumber(843);
// Console.WriteLine(ans);

// 13. ========Выяснить, кратно ли число заданному, если нет, вывести остаток.=======

// int CreateNum()
// {
//     return new Random().Next(10, 100);
// }

// int CreateDev()
// {
//     return new Random().Next(2, 10);
// }

// int firstNum = CreateNum();
// int secondNum = CreateDev();

// bool Multiple(int a, int b)
// {
//     if(a % b == 0) return true;
//     else 
//     {
//         int residual = firstNum % secondNum;
//         Console.WriteLine($"Остаток деления {firstNum} на {secondNum} равен {residual}");
//         return false;
//     }
// }

// Console.WriteLine(Multiple(firstNum, secondNum));

// 14. Найти третью цифру числа или сообщить, что её нет

// int RandomNum()
// {
//     return new Random().Next(1, 1001);
// }

// int number = RandomNum();
// Console.WriteLine(number);

// int FindThirdNum(int arg)
// {
//     if(arg / 100 >= 1) return arg /100 % 10;
//     else return -1;
// }

// Console.WriteLine(FindThirdNum(number));

// Почувствуй себя джуном

// 15. =========Дано число. Проверить кратно ли оно 7 и 23

// bool Number(int num)
// {
//     if(num % 7 == 0 && num % 23 == 0) return true;
//     else return false;
// }

// Console.WriteLine(Number(161));


// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным днём

// bool FindWeekend(int arg)
// {
//     if (arg == 6 || arg == 7) return true;
//     else return false;
// }

// Console.WriteLine(FindWeekend(7));

// 17. =====По двум заданным числам проверять является ли одно квадратом другого

// bool Func17(int a, int b)
// {
//     if (a == b * b || b == a * a ) return true;
//     else return false;
// }

// Console.WriteLine(Func17(26, 5));

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// bool Func18(bool x, bool y)
// {
//     return (!(x && y) == !x || !y);
// }

// Console.WriteLine(Func18(false, true));

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// int FindQuarter(int x, int y)
// {
//     if(x > 0 & y > 0) return 1;
//     if(x < 0 & y > 0) return 2;
//     if(x < 0 & y < 0) return 3;
//     else return 4;
// }

// Console.WriteLine(FindQuarter(3, -3));

// 20. Ввести номер четверти, показать диапазоны для возможных координат

// void InputQuarter(int arg)
// {
//     if(arg == 1) Console.WriteLine($"x>0, y>0");
//     if(arg == 2) Console.WriteLine($"x<0, y>0");
//     if(arg == 3) Console.WriteLine($"x<0, y<0");
//     if(arg == 4) Console.WriteLine($"x>0, y<0");
// }

// InputQuarter(4);

// 21. Программа проверяет пятизначное число на палиндромом.

// bool Func21(int number)
// {
//     int first = (number / 10000) % 10; 
//     int second = (number / 1000) % 10; 
//     int fourth = (number / 10) % 10; 
//     int fifth = number % 10;
//     bool result = false;
//     if(first == fifth & second == fourth) result = true;
//     return result;
// }

// bool ans = Func21(12331);
// PrintResult(ans);

// void PrintResult(bool n)
// {
//     if(n == true) Console.WriteLine("Является");
//     if(n == false) Console.WriteLine("Не является");
// }

// 22. Найти расстояние между точками в пространстве 2D/3D

//формула поиска расстояния между токами A и B = корень(xB - xA)^2 + (yB - yA)^2 + (zB - zA)^2;

// double SearchDistancePoints3D(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); 
// }

// Console.WriteLine(SearchDistancePoints3D(2, 3, 2, -5, -7, -6));

// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 

// void FuncPow(int arg)
// {
//     Console.WriteLine($"Таблица квадратов чисел от 1 до {arg}");
//     for(int i = 1; i <= arg; i++) Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
// }

// FuncPow(5);

// 24. Найти кубы чисел от 1 до N

// double[] FuncPow(int n)
// {
//     double [] array = new double [n];
//     for(int i = 1; i <= n; i++)
//     {
//         array[i - 1] = Math.Pow(i, 3);
//     }
//     return array;
// }

// double [] Cube = FuncPow(10);

// for(int index = 0; index < Cube.Length; index++) Console.WriteLine(Cube[index]);

// 25. Найти сумму чисел от 1 до А

// int a = 1000;
// int SumNumbersFrom1(int arg)
// {
//     int result = 1;
//     for(int i = 1; i <= arg; i++) result = result + i;
//     return result;
// }
// int ans = SumNumbersFrom1(a);
// Console.WriteLine(ans);

// 26. Возведите число А в натуральную степень B используя цикл

// double a = 3;
// double b = 4;

// double FuncPow(double argA, double argB)
// {
//     double result = 0;
//     for(double i = 1; i <= argA; i++) result = Math.Pow(i, argB);
//     return result;
// }
// double ans = FuncPow(a, b);
// Console.WriteLine(ans);

// 27. Определить количество цифр в числе

// int FindQuantity(int arg)
// {
//     int result = 1;
//     int div = 10;
//     for(int i = 2; i < 100; i++)
//     {
//         if(arg / div != 0)
//         {
//             div = div * 10; 
//             result = i;
//         }
//         else break;
//     }
//     return result;
// }

// int ans = FindQuantity(-125219);
// Console.WriteLine(ans);

// 28. Подсчитать сумму цифр в числе

// int SumNumbers(int num)
// {
//     int total = 0;
//     while(num != 0)
//     {
//         total = total + num % 10;
//         num = num / 10;
//     }
//     return total;
// }
// int sum = SumNumbers(153);
// Console.WriteLine(sum);

// 29. Написать программу вычисления произведения чисел от 1 до N

// int a = 10;
// int MultiplicationNumFrom1(int arg)
// {
//     int result = 1;
//     for(int i = 1; i <= arg; i++) result = result * i;
//     return result;
// }
// int ans = MultiplicationNumFrom1(a);
// Console.WriteLine(ans);

// 30. Показать кубы чисел, заканчивающихся на четную цифру

// void CubeHonestNum(int arg)   
// {
//     for(int i = 2; i <= arg; i+=2)
//     {
//         Console.WriteLine(Math.Pow(i, 3));
//     }
// }

// CubeHonestNum(10);

// Почувствуй себя сеньором
// 31. Задать массив из 8 элементов и вывести их на экран 

// string[] week = { "Дни недели: ", "пн, ", "вт, ", "ср, ", "чт, ", "пт, ", "сб, ", "вс" };

// void PrintArray(string[] arr)
// {
//     for (int i = 0; i < 8; i++) Console.Write(arr[i]);
// }

// PrintArray(week);

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива

//__________________________________________________
//  5. Написать программу вычисления значения функции y=f(a)

// double Func(double arg)
// {
//     double result = Math.Sin(arg);
//     return result;
// }

// double ans = Func(4);
// Console.WriteLine(ans);

//0. ======Вывести квадрат числа=======

// int Func(int arg)
// {
//     int result = arg * arg;
//     return result;
// }
// int ans = Func(5);
// Console.WriteLine(ans);