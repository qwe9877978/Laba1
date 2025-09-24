using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static void Main()
        {
            
            TaskProcessor processor = new TaskProcessor();

            Console.WriteLine("Выберите задачу:");
            Console.WriteLine("Задания 1");
            Console.WriteLine("1 - Проверка числа на положительность");
            Console.WriteLine("2 - Сумма двух последних цифр числа");
            Console.WriteLine("3 - Проверка, заглавный ли символ");
            Console.WriteLine("4 - Проверка деления чисел нацело");
            Console.WriteLine("5 - Многократный вызов lastNumSum");
            Console.WriteLine("Задания 2");
            Console.WriteLine("6 - Безопасное деление");
            Console.WriteLine("7 - Строка сравнения");
            Console.WriteLine("8 - Тройная сумма");
            Console.WriteLine("9 - Возраст");
            Console.WriteLine("10 - Вывод дней недели");
            Console.WriteLine("Задания 3");
            Console.WriteLine("11 - Числа наоборот");
            Console.WriteLine("12 - Степень числа");
            Console.WriteLine("13 - Проверка одинаковости цифр числа");
            Console.WriteLine("14 - Левый треугольник");
            Console.WriteLine("15 - Угадайка");
            Console.WriteLine("Задания 4");
            Console.WriteLine("16 - Поиск последнего вхождения");
            Console.WriteLine("17 - Добавление в массив");
            Console.WriteLine("18 - Реверс массива");
            Console.WriteLine("19 - Объединение массивов");
            Console.WriteLine("20 - Удалить негатив");
            Console.Write("Ваш выбор: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите число: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    bool result1 = processor.IsPositive(number);
                    if (result1)
                        Console.WriteLine("true");
                    else
                        Console.WriteLine("false");
                    break;

                case "2":
                    Console.Write("Введите число: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (Math.Abs(num) < 10)
                        Console.WriteLine("Ошибка: число должно содержать минимум две цифры!");
                    else
                        Console.WriteLine("Сумма двух последних цифр: " + processor.SumLastNums(num));
                    break;

                case "3":
                    Console.Write("Введите символ: ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    bool result3 = processor.IsUpperCase(ch);
                    if (result3)
                        Console.WriteLine("true");
                    else
                        Console.WriteLine("false");
                    break;

                case "4":
                    Console.Write("Введите первое число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    bool result4 = processor.IsDivisor(a, b);
                    if (result4)
                        Console.WriteLine("true");
                    else
                        Console.WriteLine("false");
                    break;

                case "5":
                    int result = 0;

                    Console.Write("Введите число 1: ");
                    int firstNum = Convert.ToInt32(Console.ReadLine());
                    result = Math.Abs(firstNum) % 10;

                    for (int i = 2; i <= 5; i++)
                    {
                        Console.Write("Введите число " + i + ": ");
                        int currentNum = Convert.ToInt32(Console.ReadLine());
                        int previousResult = result;
                        result = processor.LastNumSum(result, currentNum);
                        Console.WriteLine(previousResult + "+" + currentNum + " это " + result);
                    }

                    Console.WriteLine("Итоговый результат: " + result);
                    break;

                case "6":
                    Console.Write("Введите делимое (x): ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите делитель (y): ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    double divisionResult = processor.SafeDiv(x, y);
                    Console.WriteLine("Результат деления: " + divisionResult);
                    break;

                case "7":
                    Console.Write("Введите первое число (x): ");
                    int xVal = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число (y): ");
                    int yVal = Convert.ToInt32(Console.ReadLine());

                    string comparisonResult = processor.MakeDecision(xVal, yVal);
                    Console.WriteLine("Результат сравнения: " + comparisonResult);
                    return;

                case "8":
                    Console.Write("Введите первое число: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите третье число: ");
                    int num3 = Convert.ToInt32(Console.ReadLine());

                    bool sum3Result = processor.Sum3(num1, num2, num3);
                    if (sum3Result)
                        Console.WriteLine("true");
                    else
                        Console.WriteLine("false");
                    break;

                case "9":
                    Console.Write("Введите возраст: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    string ageResult = processor.Age(age);
                    Console.WriteLine(ageResult);
                    break;

                case "10":
                    Console.Write("Введите день недели: ");
                    string day = Console.ReadLine();
                    processor.PrintDays(day);
                    break;

                case "11":
                    Console.Write("Введите число: ");
                    int inputNum = Convert.ToInt32(Console.ReadLine());
                    string reversedList = processor.ReverseListNums(inputNum);
                    Console.WriteLine(reversedList);
                    break;

                case "12":
                    Console.Write("Введите основание степени (x): ");
                    int baseNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите показатель степени (y): ");
                    int exponent = Convert.ToInt32(Console.ReadLine());

                    int powerResult = processor.Pow(baseNum, exponent);
                    Console.WriteLine("Результат: " + powerResult);
                    break;

                case "13":
                    Console.Write("Введите число: ");
                    int checkNum = Convert.ToInt32(Console.ReadLine());
                    bool equalResult = processor.EqualNum(checkNum);
                    if (equalResult)
                        Console.WriteLine("true");
                    else
                        Console.WriteLine("false");
                    break;

                case "14":
                    Console.Write("Введите высоту треугольника: ");
                    int height = Convert.ToInt32(Console.ReadLine());
                    processor.LeftTriangle(height);
                    break;

                case "15":
                    processor.GuessGame();
                    break;

                case "16":
                    Console.WriteLine("Введите элементы массива через пробел:");
                    string[] inputArray = Console.ReadLine().Split(' ');
                    int[] arr = new int[inputArray.Length];

                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        arr[i] = Convert.ToInt32(inputArray[i]);
                    }

                    Console.Write("Введите число для поиска: ");
                    int searchNum = Convert.ToInt32(Console.ReadLine());

                    int lastIndex = processor.FindLast(arr, searchNum);
                    Console.WriteLine("Индекс последнего вхождения: " + lastIndex);
                    break;

                case "17":
                    Console.WriteLine("Введите элементы массива через пробел:");
                    string[] inputArr = Console.ReadLine().Split(' ');
                    int[] originalArray = new int[inputArr.Length];

                    for (int i = 0; i < inputArr.Length; i++)
                    {
                        originalArray[i] = Convert.ToInt32(inputArr[i]);
                    }

                    Console.Write("Введите число для добавления: ");
                    int newValue = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите позицию для вставки: ");
                    int position = Convert.ToInt32(Console.ReadLine());

                    int[] newArray = processor.Add(originalArray, newValue, position);

                    Console.WriteLine("Исходный массив: [" + string.Join(", ", originalArray) + "]");
                    Console.WriteLine("Новый массив: [" + string.Join(", ", newArray) + "]");
                    break;

                case "18":
                    Console.WriteLine("Введите элементы массива через пробел:");
                    string[] inputReverse = Console.ReadLine().Split(' ');
                    int[] reverseArray = new int[inputReverse.Length];

                    for (int i = 0; i < inputReverse.Length; i++)
                    {
                        reverseArray[i] = Convert.ToInt32(inputReverse[i]);
                    }

                    Console.WriteLine("Исходный массив: [" + string.Join(", ", reverseArray) + "]");
                    processor.Reverse(reverseArray);
                    Console.WriteLine("Реверсированный массив: [" + string.Join(", ", reverseArray) + "]");
                    break;

                case "19":
                    Console.WriteLine("Введите элементы первого массива через пробел:");
                    string[] inputArr1 = Console.ReadLine().Split(' ');
                    int[] array1 = new int[inputArr1.Length];

                    for (int i = 0; i < inputArr1.Length; i++)
                    {
                        array1[i] = Convert.ToInt32(inputArr1[i]);
                    }

                    Console.WriteLine("Введите элементы второго массива через пробел:");
                    string[] inputArr2 = Console.ReadLine().Split(' ');
                    int[] array2 = new int[inputArr2.Length];

                    for (int i = 0; i < inputArr2.Length; i++)
                    {
                        array2[i] = Convert.ToInt32(inputArr2[i]);
                    }

                    int[] concatenatedArray = processor.Concat(array1, array2);

                    Console.WriteLine("Первый массив: [" + string.Join(", ", array1) + "]");
                    Console.WriteLine("Второй массив: [" + string.Join(", ", array2) + "]");
                    Console.WriteLine("Объединенный массив: [" + string.Join(", ", concatenatedArray) + "]");
                    break;

                case "20":
                    Console.WriteLine("Введите элементы массива через пробел:");
                    string[] inputNegative = Console.ReadLine().Split(' ');
                    int[] negativeArray = new int[inputNegative.Length];

                    for (int i = 0; i < inputNegative.Length; i++)
                    {
                        negativeArray[i] = Convert.ToInt32(inputNegative[i]);
                    }

                    int[] positiveArray = processor.DeleteNegative(negativeArray);

                    Console.WriteLine("Исходный массив: [" + string.Join(", ", negativeArray) + "]");
                    Console.WriteLine("Массив без отрицательных элементов: [" + string.Join(", ", positiveArray) + "]");
                    break;

                default:
                    Console.WriteLine("Некорректный ввод!");
                    break;
            }
        }
    }
}
