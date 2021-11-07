// Почувствуй себя интерном
//  0. ======Вывести квадрат числа=======

// int Func(int x)
// {
//     return x * x;
// }
// int res = Func(5);
// Console.WriteLine(res);

//  1. По двум заданным числам проверять является ли первое квадратом второго

// void Func1(int x, int y)
// {
//     if(x == y * y) Console.WriteLine($"Число {x} является квадратом числа {y}");
//     if(y == x * x) Console.WriteLine($"Число {y} является квадратом числа {x}");
//     else Console.WriteLine("Не является");
// }
// Func1(25, 3);


//  2. Даны два числа. Показать большее и меньшее число

// int CreateNum()
// {
//     int number = new Random().Next(1, 100);
//     return number;
// }

// int a = CreateNum();
// int b = CreateNum();

// void FindMaxNumber(int x, int y)
// {
//     if(x > y) Console.WriteLine($"{x} > {y}");
//     if(y > x) Console.WriteLine($"{y} > {x}");
//     if(x == y) Console.WriteLine($"{x} = {y}");
// }

// FindMaxNumber(a, b);

//  3. =======По заданному номеру дня недели вывести его название=======

// void Func(int x)
// {
//     string [] array = {"monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "Sunday"};
//     Console.WriteLine(array[x - 1]); 
// }
// Func(1);

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
//     int number = new Random().Next(1, 100);
//     return number;
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

// double f(double a)
// {
//     double res = Math.Sin (a);
//     return res;
// }
// double sin = f(2);
// Console.Write(sin);

//  6. =======Выяснить является ли число чётным========

// void Func(int a)
// {
//     if(a % 2 == 0)
//     {
//         Console.WriteLine("Является четным");
//     }
//     else
//     {
//         Console.WriteLine("Не является четным");
//     }
// }
// Func(5);


//  7. =======Показать числа от -N до N========

// int [] arrayA = new int [10];

// void CreateArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 11);
//     }
// }

// void ShowArray(int [] array)
// {
//     for(int ind = 0; ind < array.Length; ind++)
//     {
//         Console.Write($"{arrayA[ind]} ");
//     }
// }

// CreateArray(arrayA);
// ShowArray(arrayA);

//  8. =========Показать четные числа от 1 до N=========

// int [] arrayA = new int [10];

// void CreateArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 21);
//     }
// }

// void ShowArray(int [] array)
// {
//     for(int ind = 0; ind < array.Length; ind++)
//     {
//         Console.Write($"{arrayA[ind]} ");
//     }
// }

// void ShowEven(int [] array)
// {
//     for(int index = 0; index < array.Length; index++)
//     if(arrayA[index] % 2 == 0)
//     {
//         Console.Write($"{arrayA[index]} ");
//     }
// }

// CreateArray(arrayA);
// ShowArray(arrayA);
// Console.WriteLine();
// ShowEven(arrayA);

//  9. =====Показать последнюю цифру трёхзначного числа======

// int LastNumber(int arg)
// {
//     arg = arg % 10;
//     return arg;
// }
// int ans = LastNumber(251);
// Console.WriteLine(ans);

// 10. =========Показать вторую цифру трёхзначного числа========

// int SecNumber(int arg)
// {
//     arg = arg / 10 % 10;
//     return arg;
// }
// int ans = SecNumber(298);
// Console.WriteLine(ans);

// 11. =========Дано число из отрезка [10, 99]. Показать наибольшую цифру числа=======

// void MaxNum(int arg)
// {
//     int a = 0;
//     int b = 0;
//     a = arg / 10;
//     b = arg % 10;
//     if(a > b)
//     {
//         Console.WriteLine(a);
//     }
//     else
//     {
//         Console.WriteLine(b);
//     }
// }

// int CreateNum()
// {
//     int ranNum = new Random().Next(10, 100);
//     return ranNum;
// }

// int number = CreateNum();
// Console.WriteLine(number);
// MaxNum(number);

// 12. ======Удалить вторую цифру трёхзначного числа=========

// void DeleteSecNumber(int arg)
// {
//     int a = arg / 100;
//     int b = arg % 10;
//     int c = a * 10 + b;
//     Console.WriteLine(c);
// }

// DeleteSecNumber(371);

// 13. ========Выяснить, кратно ли число заданному, если нет, вывести остаток.=======

// int CreateNum()
// {
//     int ranNum = new Random().Next(10, 100);
//     return ranNum;
// }

// int CreateDev()
// {
//     int devNum = new Random().Next(2, 10);
//     return devNum;
// }

// int firstNum = CreateNum();
// int secondNum = CreateDev();

// if(firstNum % secondNum == 0)
// {
//     Console.WriteLine($"Число {firstNum} кратно {secondNum}");
// }
// else
// {
//     int residual = firstNum % secondNum;
//     Console.WriteLine($"Остаток деления {firstNum} на {secondNum} равен {residual}");
// }

// 14. Найти третью цифру числа или сообщить, что её нет

// int RandomNum()
// {
//     int x = new Random().Next(1, 1000);
//     return x;
// }

// int number = RandomNum();

// void FindThirdNum(int arg)
// {
//     if((number / 100) >= 1)
//     {
//         int y = number % 10;
//         Console.WriteLine($"Третьей цифрой числа {number} является {y}");
//     }
//     else
//     {
//         Console.WriteLine("Третьей цифры в числе нет!");
//     }
// }
// FindThirdNum(number);

// Почувствуй себя джуном

// 15. =========Дано число. Проверить кратно ли оно 7 и 23

// int Number(int num)
// {
//     int result = 0;
//     if(num % 7 == 0)
//     {
//         if(num % 23 == 0) result = 1; 
//     }
//     return result;
// }
// int ans = Number(160);
// Console.WriteLine(ans);

// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

// bool FindWeekend(int arg)
// {
//     bool result = false;
//     int week = 7;
//     int weekend = 6 & 7;
//     for(int i = 1; i <= week; i++)
//     {
//         if(arg == weekend) result = true;
//     }
//     return result;
// }

// bool ans = FindWeekend(6);
// Console.WriteLine(ans);

// 17. =====По двум заданным числам проверять является ли одно квадратом другого

// int Func17(int a, int b)
// {
//     int res = 0;
//     if (a > b)
//     {
//        if (a == b * b) res = 1;
//     }
//     else
//     {
//       if (b == a * a) res = 2;  

//     }
//     return res;
// }
// int firstNum = 5;
// int secondNum = 25;
// int ans = Func17(firstNum, secondNum);

// void PrintFunc(int arg)
// {
//     if (ans == 0) Console.WriteLine("ни одно число не является квадратом другого");
//     if (ans == 1) Console.WriteLine($"{firstNum} является квадратом {secondNum}");
//     if (ans == 2) Console.WriteLine($"{secondNum} является квадратом {firstNum}");
// }
// PrintFunc(ans);


// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// bool Func18(bool x, bool y)
// {
//     return (!(x & y) == !x || !y);
// }

// bool ans = Func18(false, true);
// Console.WriteLine(ans);

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// int FindQuarter(int x, int y)
// {
//     int quarter = 0;
//     if(x > 0 & y > 0) quarter = 1;
//     if(x < 0 & y > 0) quarter = 2;
//     if(x < 0 & y < 0) quarter = 3;
//     if(x > 0 & y < 0) quarter = 4;
//     return quarter;
// }

// int ans = FindQuarter(3, -3);
// Console.WriteLine(ans);

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
//     double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); 
//     return result;
// }
// double ans = SearchDistancePoints3D(2, 3, 2, -5, -7, -6);
// Console.WriteLine(ans);

// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 

// int n = 5;
// Console.WriteLine($"Таблица квадратов чисел от 1 до {n}");

// void FuncPow(int arg)
// {
//     for(int i = 1; i <= arg; i++)
//     {
//         double result = Math.Pow(i, 2);
//         Console.WriteLine($"{i}^2 = {result}");
//     }
// }
// FuncPow(n);

// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

// Почувствуй себя сеньором
// 31. Задать массив из 8 элементов и вывести их на экран 
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