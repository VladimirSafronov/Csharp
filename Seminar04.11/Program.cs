// Почувствуй себя интерном
//  0. ======Вывести квадрат числа=======

// int Func(int x)
// {
//     return x * x;
// }
// Console.WriteLine(Func(5));

//  1. По двум заданным числам проверять является ли первое квадратом второго

// bool Func1(int x, int y)
// {
//     return x == y * y;
// }
// Console.WriteLine(Func1(26, 5));

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

// Console.WriteLine($"Максимальное число {FindMaxNumber(a, b, c)}");

//  5. Написать программу вычисления значения функции y=f(a)

// double F(double a)
// {
//     return Math.Sin (a);
// }

// Console.Write(F(2));

//  6. =======Выяснить является ли число чётным========

// bool Func(int a)
// {
//     return a % 2 == 0;
// }
// Console.WriteLine(Func(6));

//  7. =======Показать числа от -N до N========

// int n = 3;

// int[] CreateArray( int arg)
// {
//     int [] arrayA = new int [arg * 2 + 1];  //+1 для того, чтобы влез 0
//     for(int i = -arg; i <= arg; i++)
//     {
//         arrayA[i + arg] = i;
//     }
//     return arrayA;
// }

// int[] arr =CreateArray(n);

// // for(int count = 0; count < arrayA.Length; count++) Console.Write($"{arrayA[count]} ");
// Console.WriteLine(String.Join(',', arr)); //вывод массива на экран через запятую

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

// int[] honest(int[] array)
// {
//     int count = 0;
//     for(int index = 0; index < arrayA.Length; index++) if(arrayA[index] % 2 == 0) count++;
//     int[] arr = new int[count];
//     count = 0;
//     int l = 0;
//     while(l < arrayA.Length) 
//     {
//         if(arrayA[l] % 2 == 0) 
//         {
//             arr[count] = arrayA[l];
//             count++;
//             l++;
//         }
//         else l++;
//     }
//     return arr;
// }

// int[] arrayB = honest(arrayA);
// for(int k = 0; k < arrayB.Length; k++) Console.Write($"{arrayB[k]} ");

//  9. =====Показать последнюю цифру трёхзначного числа======

// int LastNumber(int arg)
// {
//     if(arg < 0) arg = arg * -1;
//     return arg % 10;
// }
// Console.WriteLine(LastNumber(349));

// 10. =========Показать вторую цифру трёхзначного числа========

// int SecNumber(int arg)
// {
//     if(arg < 0) arg = arg * -1;
//     return arg / 10 % 10;
// }

// Console.WriteLine(SecNumber(735));

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
// Console.WriteLine(DeleteSecNumber(-341));

// 13. =======Выяснить, кратно ли число заданному, если нет, вывести остаток.=======

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
// Console.Write($"{firstNum} {secondNum}");
// Console.WriteLine();

// int Multiple(int a, int b)
// {
//     if(a % b == 0) return -1;   //в случае кратности чисел выведет -1
//     else return firstNum % secondNum;
// }

// Console.WriteLine(Multiple(firstNum, secondNum));

// 14. Найти третью цифру числа или сообщить, что её нет

// int RandomNum()
// {
//     return new Random().Next(-150, 150);
// }

// int number = RandomNum();
// Console.WriteLine(number);

// int FindHundredNum(int arg)
// {
//     if(arg / 100 != 0) 
//     {
//         arg = arg /100 % 10;
//         if(arg < 0) return arg * -1;    //выводит только положительные цифры
//         else return arg;
//     }
//     else return -1;  //вывод -1 означает, что третьей цифры нет
// }

// Console.WriteLine(FindHundredNum(1357));

// int FindThirdNum(int arg)
// {
//     arg = Math.Abs(arg);
//     if(arg / 100 == 0) return -1;
//     else 
//     {
//         while(arg / 100 > 9) arg = arg / 10;
//         return arg % 10;
//     }
// }
// Console.WriteLine(FindThirdNum(-56854802));

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

// string InputQuarter()
// {
//     Console.WriteLine("Введите номер четверти: ");
//     string a = Console.ReadLine();
//     int arg = Convert.ToInt16(a);
//     if(arg == 1) return ($"x>0, y>0");
//     if(arg == 2) return ($"x<0, y>0");
//     if(arg == 3) return ($"x<0, y<0");
//     if(arg == 4) return ($"x>0, y<0");
//     else return ($"Впишите номер от 1 до 4!");
// }

// string ans = InputQuarter();
// Console.WriteLine(ans);

// 21. Программа проверяет пятизначное число на палиндромом.

// bool Func21(int n)
// {
//     if(n / 10000 % 10 == n % 10 && n / 1000 % 10 == n / 10 % 10) return true;
//     else return false;
// }

// Console.WriteLine(Func21(48594));

// 22. Найти расстояние между точками в пространстве 2D/3D

//формула поиска расстояния между токами A и B = корень(xB - xA)^2 + (yB - yA)^2 + (zB - zA)^2;

// double SearchDistancePoints2D(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); 
// }

// Console.WriteLine(SearchDistancePoints2D(2, 3, -5, -7));


// double SearchDistancePoints3D(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); 
// }

// Console.WriteLine(SearchDistancePoints3D(2, 3, 2, -5, -7, -6));

// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 

// double[] FuncPow(int arg)
// {
//     double [] array = new double [arg];
//     for(int i = 1; i <= arg; i++) array[i-1] = Math.Pow(i, 2);
//     return array;
// }
// int n = 10;
// double[] Array = FuncPow(n);

// for(int k = 1; k <= Array.Length; k++) Console.WriteLine($"{k}^2 = {Array[k-1]}");

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

// Console.WriteLine(String.Join(',', Cube));

// 25. Найти сумму чисел от 1 до А

// double a = 1000;
// double SumNumbersFrom1(double arg)
// {
//     double result = 0;
//     for(double i = 1; i <= arg; i++) result = result + i;
//     return result;
// }
// double res = SumNumbersFrom1(a);
// DateTime dt = DateTime.Now;
// Console.WriteLine(res);
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
// //__________________________
// int SumNumbers2(int arg)
// {
//     return (arg * (arg + 1)) / 2;  //формула, сильно ускоряющая работу метода
// }
// dt = DateTime.Now;
// Console.WriteLine(SumNumbers2(a));
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// 26. Возведите число А в натуральную степень B используя цикл

// double a = 1.13;
// int b = 5;

// double FuncPow(double argA, int argB)
// {
//     double result = argA;
//     for(int i = 1; i < argB; i++) result = result * argA;
//     return result;
// }
// Console.WriteLine(FuncPow(a, b));

// 27. Определить количество цифр в числе

// int FindQuantity(int arg)
// {
//     arg = Math.Abs(arg);
//     int result = 1;
//     while(arg > 10) 
//     {
//         arg = arg / 10;
//         result ++;
//     }
//     return result;
// }

// Console.WriteLine(FindQuantity(-8641219));

// 28. Подсчитать сумму цифр в числе

// int SumNumbers(int num)
// {
//     int total = 0;
//     num = Math.Abs(num);
//     while(num != 0)
//     {
//         total = total + num % 10;
//         num = num / 10;
//     }
//     return total;
// }

// Console.WriteLine(SumNumbers(1135));

// 29. Написать программу вычисления произведения чисел от 1 до N

// int n = 10;
// int MultiplicationNumFrom1(int arg)
// {
//     int result = 1;
//     for(int i = 1; i <= arg; i++) result = result * i;
//     return result;
// }
// Console.WriteLine(MultiplicationNumFrom1(n));

// 30. Показать кубы чисел, заканчивающихся на четную цифру

// double[] CubeLastEvenNum(int first, int last)   
// {
//     double [] array = new double[(last - first +1) / 2];  //+1, чтобы влезало в массив при четном начале
//     if(first % 2 != 0) first +=1;
//     int count = 0;
//     for(int i = first; i <= last; i+=2) 
//     {
//         array[count] = Math.Pow(i, 3); 
//         count++;
//     }
//     return array;
// }
// double[] Array = CubeLastEvenNum(8, 21); 
// for(int j = 0; j < Array.Length; j++) Console.WriteLine(Array[j]);

// Почувствуй себя сеньором
// 31. Задать массив из 8 элементов и вывести их на экран 

// string[] week = { "Дни недели:", " пн", " вт", " ср", " чт", " пт", " сб", " вс" };

// void PrintArray(string[] arr)
// {
//     for (int i = 0; i < 8; i++) Console.Write(arr[i]);
// }

// PrintArray(week);

// Console.WriteLine(String.Join(',', week)); //упрощенный вывод массива

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

// int [] CreateArray()
// {
//     int [] array = new int [8];
//     for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 2);
//     return array;
// }
// int[] Array01 = CreateArray();

// Console.WriteLine(String.Join(',', Array01));

// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

// int[] CreateArr()
// {
//     int[] array = new int [12];
//     for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(-9, 10);
//     return array;
// }

// int[] Array9 = CreateArr();
// Console.WriteLine(String.Join(',', Array9));
// Console.WriteLine();

// (int pos, int neg) FindSumPositiveAndNegativeNum(int[] array)
// {
//     int positiveTotal = 0;
//     int negativeTotal = 0;
//     for(int i = 0; i < array.Length; i++) 
//     if(array[i] > 0) positiveTotal = positiveTotal + array[i];
//     else negativeTotal = negativeTotal + array[i];
//     return (positiveTotal, negativeTotal);
// }

// Console.WriteLine(FindSumPositiveAndNegativeNum(Array9));

// 34. Написать программу замену элементов массива на противоположные

// int[] Array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

// int[] ChangeArrayElement(int[] array)
// {
//     int temporary = 0; int rear = array.Length - 1;
//     for(int front = 0; front < array.Length/2; front++) //дохожу до середины массива
//     {
//         temporary = array[front];
//         array[front] = array[rear];
//         array[rear] = temporary;
//         rear --;
//     }
//     return array;
// }

// int[] RearArray = ChangeArrayElement(Array);

// Console.WriteLine(String.Join('|', RearArray));

// 35. Определить, присутствует ли в заданном массиве, некоторое число 

// int[] MadeArray()
// {
//     int[] array = new int [10];
//     for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 10);
//     return array;
// }

// int[] NewArray = MadeArray();
// Console.WriteLine(String.Join(',', NewArray));

// bool FindNumber(int arg, int[] array)
// {
//     bool ans = false;
//     int k = 0;
//     while(k < array.Length) 
//     {
//         if(array[k] == arg) 
//         {
//             ans = true;
//             break;
//         }
//         k++;
//     }
//     return ans;
// }

// Console.WriteLine(FindNumber(5, NewArray));


// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// int[] CreateArray()
// {
//     int[] array = new int [15];
//     for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(100, 1000);
//     return array;
// }

// int[] RandomArray = CreateArray();

// Console.WriteLine(String.Join(',', RandomArray));

// (int a, int b) FindOddEven(int[] array)
// {
//     int odd = 0; int even = 0;
//     for(int k = 0; k < array.Length; k++)
//     {
//         if(array[k] % 2 != 0) odd +=1;
//         else even +=1;
//     }
//     return (odd, even);
// }

// Console.WriteLine(FindOddEven(RandomArray));   //показывает нечетные, затем четные.


// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int[] MakeArray()
// {
//     int[] array = new int [123];
//     for(int i = 0; i < array.Length; i++) array[i] = i;
//     return array;
// }

// int[] arrayA = MakeArray();

// int Find00(int[] array)
// {
//     int number = 0;
//     for(int count = 0; count < array.Length; count++) 
//     {
//         if(array[count] / 10 > 0 && array[count] / 10 < 10) number +=1;
//     }
//     return number;
// }

// Console.WriteLine(Find00(arrayA));

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// int[] CreateArray()
// {
//     int[] array = new int[15];
//     for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 10);
//     return array;
// }

// int[] arrayA = CreateArray();

// Console.WriteLine(String.Join(',', arrayA));

// int SumOddPosition(int[] array)
// {
//     int sum = 0;
//     for(int count = 0; count < array.Length; count +=2) sum = sum + array[count];
//     return sum;
// }

// Console.WriteLine(SumOddPosition(arrayA));

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int[] CreateArray()
// {
//     int[] array = new int [10];
//     for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 10);
//     return array;
// }

// int[] arrayA = CreateArray();
// Console.WriteLine(String.Join(',', arrayA));

// int[] multiplicationPairs(int[] array)
// {
//     int rear = array.Length -1;
//     int[] multPairs = new int[array.Length / 2];  //при нечетной длинне массива, средний элемент теряется, т.к. для него нет пары
//     for(int count = 0; count < multPairs.Length; count++) 
//     {
//         multPairs[count] = array[count] * array [rear];
//         rear--;
//     }
//     return multPairs;
// }

// int[] arrayB = multiplicationPairs(arrayA);
// Console.WriteLine(String.Join(',', arrayB));

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// double[] makeArray()
// {
//     double[] array = new double[10];
//     for(int i = 0; i < array.Length; i++) array[i] = new Random().NextDouble();
//     return array;
// }

// double[] arrayA = makeArray();


// double FindMaxValue(double[] array)
// {
//     double maxValue = 0.0;
//     for(int i = 0; i < array.Length; i++) if(array[i] > maxValue) maxValue = array[i];
//     return maxValue;
// }


// double FindMinValue(double[] array)
// {
//     double minValue = 1.0;
//     for(int k = 0; k < array.Length; k++) if(array[k] < minValue) minValue = array[k];
//     return minValue;
// }


// double SubMaxValueAndMinValue(double argMax, double argMin)
// {
//     return argMax - argMin;
// }

// Console.WriteLine(SubMaxValueAndMinValue(FindMaxValue(arrayA), FindMinValue(arrayA)));

// Почувствуй себя лидом
//41. Выяснить являются ли три числа сторонами треугольника 

// string InputNumbers()
// {
//     Console.WriteLine("Введите числа через пробел:");
//     return Console.ReadLine();
// }

// string numbers = InputNumbers();

// int findLength(string num)
// {
//     int lengt = 0;
//     for(int i = 0; i < num.Length; i++) if(num[i] == ' ') lengt +=1;
//     return lengt + 1;
// }

// int lengthArray = findLength(numbers);

// int[] arrayFromString(int numb, string numbers)
// {
//     int j = 0;
//     int[] array = new int[numb];
//     int i = 0;
//     while(i < array.Length)
//     {
//         if(numbers[j] != ' ') 
//         {
//             array[i] = Int32.Parse("" + numbers[j]);  //схитрил
//             i++;
//             j++;
//         }
//         else j++;
//     }
//     return array;
// }

// int[] arrayA = arrayFromString(lengthArray, numbers);

// bool IsThisTriangle(int[] arr)
// {
//     if(arr[0] + arr[1] > arr[2] && arr[1] + arr[2] > arr[0] && arr[0] + arr[2] > arr[1]) return true;
//     else return false;
// }

// Console.WriteLine(IsThisTriangle(arrayA));

// // 42. Определить сколько чисел больше 0 введено с клавиатуры

// string EnteredNumbers()
// {
//     Console.WriteLine("Введите число через запятую:");
//     return Console.ReadLine();
// }
// string text = EnteredNumbers();

// int lengthOfArray (string text) 
// {
//     int ans = 0;
//     for(int i = 0; i < text.Length; i++)
//     {
//         if(text[i] == ',') ans++; 
//     }
//     return ans + 1;
// }

// string[] translateToArray(string text, int lengthArr)   
// {
//     string[] array = new string[lengthArr];
//     int index = 0;
//     for(int i = 0; i < text.Length; i++)   
//     {
//         if(text[i] != ',') array[index] = array[index] + text[i];
//         else index++;
//     } 
//     return array;
// }

// string[] textArray = translateToArray(text, lengthOfArray(text));

// int[] fromStringToInt (string[] arrayText)
// {
//     int[] array = new int[arrayText.Length];
//     for(int i = 0; i < arrayText.Length; i++) array[i] = int.Parse(arrayText[i]);
//     return array;
// }

// int[] arrayNumbers = fromStringToInt(textArray);

// int PositiveNumbers (int[] array)
// {
//     int ans = 0;
//     for(int l = 0; l < array.Length; l++) 
//     {
//         if(array[l] > 0) ans +=1;
//     }
//     return ans;
// }

// Console.WriteLine(PositiveNumbers(arrayNumbers));

//__________________________________
// string abc = "hf,kv,udhvtu,5,8,fg,h4,-5";

// int lengthOfArray (string text)  //метод, находящий длинну текстового массива
// {
//     int ans = 0;
//     for(int i = 0; i < text.Length; i++)
//     {
//         if(text[i] == ',') ans++; 
//     }
//     return ans + 1;
// }

// Console.WriteLine(lengthOfArray(abc));

// string[] translateToArray(string text, int lengthArr)   //метод, создающий строчный массив из текста
// {
//     string[] array = new string[lengthArr];
//     int index = 0;
//     for(int i = 0; i < text.Length; i++)   //имеется встроенный функционал - phrase.Split
//     {
//         if(text[i] != ',') array[index] = array[index] + text[i];
//         else index++;
//     } 
//     return array;
// }

// string[] textArray = translateToArray(abc, lengthOfArray(abc));

// Console.WriteLine(String.Join(',', textArray));

// string[] filtrNumbers(string[] array)   //не закончил, тут пытаюсь оставить только элементы с числовыми значениями
// {
//     string[] filtrArr = new string[array.Length];
//     int count = 0;
//     for(int k = 0; k < array.Length; k++)
//     {
//        if(array[k] == '-');
//     }
// }


// 43. Написать программу преобразования десятичного числа в двоичное

// int[] createArr(int arg)
// {
//     int[] array = new int[10];
//     int i = 0;
//     while(arg > 0)
//     {
//         if(arg % 2 == 0) array[i] = 0;
//         else array[i] = 1;
//         i++;
//         arg = arg / 2;
//     }
//     return array;
// }

// int[] ChangeToBinary(int[] array)
// {
//     int last = array.Length -1; int temporary = 0;
//     for(int first = 0; first < array.Length / 2; first++)
//     {
//         temporary = array[first]; 
//         array[first] = array[last];
//         array[last] = temporary;
//         last --;
//     }
//     return array;
// }

// int[] firstArr = ChangeToBinary(createArr(657));
// Console.WriteLine(String.Join(' ', firstArr));

//_________________________

// int decimalNum = int.Parse(Console.ReadLine());

// int findIndexNumArray(int arg)
// {
//     int i = 0; 
//     while(arg > 0)
//     {
//         arg = arg/2;
//         i++;
//     }
//     return i;
// }

// int[] ChangeToBinary(int index, int arg)
// {
//     int[] array = new int[index];
//     int last = array.Length - 1;
//     for(int j = 0; j < array.Length; j++)
//     {
//         if(arg % 2 == 0) array[last] = 0;
//         else array[last] = 1;
//         arg = arg / 2;
//         last -=1;
//     }
//     return array;
// }


// int[] binarArray = ChangeToBinary(findIndexNumArray(decimalNum), decimalNum);
// Console.WriteLine(String.Join(' ', binarArray));

// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for(int i = 1; i < 11; i++) Console.WriteLine(Fibonacci(i));

// 46. Написать программу масштабирования фигуры

// string Input()
// {
//     Console.WriteLine("Введите координаты точек через пробел:");
//     return Console.ReadLine();
// }

// string[] fromStringToArray(string num)  //создаем строчный массив
// {
//     return num.Split(' ');
// }

// int[] fromStrToInt(string[] numbers)  //переводим строчный массив в числовой, в методе присутствует ловушка для букв
// {
//     int[] point = new int[numbers.Length];
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         try
//         {
//             point[i] = Convert.ToInt32(numbers[i]);
//         }
//         catch(Exception) 
//         {
//             Console.WriteLine("Ошибка при вводе");
//         }
//     }
//     return point;
// }

// Console.WriteLine();
// int[] points = fromStrToInt(fromStringToArray(Input()));  //числовой массив с координатами точек

// int[] Scale(int[] points, int n)
// {
//     // int firstSide = points[3] - points[1];
//     // int secondSide = points[4] - points[2];
//     int ratioSides = (points[4] - points[2]) / (points[3] - points[1]); //находим соотношение длины сторон
//     int[] newPoints = new int[points.Length];
//     newPoints[0] = points[0];
//     newPoints[1] = points[1];
//     newPoints[2] = points[2];
//     newPoints[3] = points[3] * n;
//     newPoints[4] = points[4] * n * ratioSides;
//     newPoints[5] = points[5] * n;
//     newPoints[6] = points[6] * n * ratioSides;
//     newPoints[7] = points[7];
//     return newPoints;   //получилось так себе. Работает, если задаем точки против часовой стрелке, начиная с нижнего левого края.
// }

// int[] newPoints = Scale(points, 2);
// Console.WriteLine(String.Join(',', newPoints));

// 47. Написать программу копирования массива


//переполнение типа:

// byte a1 = 255;
// a1=(byte)(a1+1);
// Console.WriteLine(a1);