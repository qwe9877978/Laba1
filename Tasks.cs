using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{

    public class TaskProcessor
    {
        // Проверка положительности числа
        public bool IsPositive(int x)
        {
            if (x > 0)
                return true;
            else
                return false;
        }

        // Сумма двух последних цифр числа
        public int SumLastNums(int x)
        {
            int num = Math.Abs(x);
            int lastDigit = num % 10;
            int secondLastDigit = (num / 10) % 10;
            return lastDigit + secondLastDigit;
        }

        // Проверка заглавной буквы
        public bool IsUpperCase(char x)
        {
            if (char.IsUpper(x))
                return true;
            else
                return false;
        }

        // Проверка, делит ли одно число другое нацело
        public bool IsDivisor(int a, int b)
        {
            if ((b != 0 && a % b == 0) || (a != 0 && b % a == 0))
                return true;
            else
                return false;
        }

        // Сумма последних цифр двух чисел
        public int LastNumSum(int a, int b)
        {
            return (Math.Abs(a) % 10) + (Math.Abs(b) % 10);
        }

        // Безопасное деление с проверкой на ноль
        public double SafeDiv(int x, int y)
        {
            if (y == 0)
                return 0;
            else
                return (double)x / y;
        }

        // Сравнение двух чисел и формирование строки с результатом
        public string MakeDecision(int x, int y)
        {
            if (x > y)
                return x + " > " + y;
            else if (x < y)
                return x + " < " + y;
            else
                return x + " == " + y;
        }

        // Проверка, равна ли сумма двух чисел третьему
        public bool Sum3(int x, int y, int z)
        {
            if (x + y == z || x + z == y || y + z == x)
                return true;
            else
                return false;
        }

        // Формирование строки с возрастом и правильным склонением
        public string Age(int x)
        {
            int lastDigit = Math.Abs(x) % 10;
            int lastTwoDigits = Math.Abs(x) % 100;

            // Исключения для чисел 11-14
            if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
                return x + " лет";

            if (lastDigit == 1)
                return x + " год";
            else if (lastDigit >= 2 && lastDigit <= 4)
                return x + " года";
            else
                return x + " лет";
        }

        // Вывод дней недели начиная с заданного
        public void PrintDays(string x)
        {
            string day = x.ToLower();

            switch (day)
            {
                case "понедельник":
                    Console.WriteLine("понедельник");
                    Console.WriteLine("вторник");
                    Console.WriteLine("среда");
                    Console.WriteLine("четверг");
                    Console.WriteLine("пятница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;

                case "вторник":
                    Console.WriteLine("вторник");
                    Console.WriteLine("среда");
                    Console.WriteLine("четверг");
                    Console.WriteLine("пятница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;

                case "среда":
                    Console.WriteLine("среда");
                    Console.WriteLine("четверг");
                    Console.WriteLine("пятница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;

                case "четверг":
                    Console.WriteLine("четверг");
                    Console.WriteLine("пятница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;

                case "пятница":
                    Console.WriteLine("пятница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;

                case "суббота":
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;

                case "воскресенье":
                    Console.WriteLine("воскресенье");
                    break;

                default:
                    Console.WriteLine("это не день недели");
                    break;
            }
        }

        // Формирование строки с числами от x до 0
        public string ReverseListNums(int x)
        {
            StringBuilder result = new StringBuilder();

            if (x >= 0)
            {
                for (int i = x; i >= 0; i--)
                {
                    result.Append(i);
                    if (i > 0) result.Append(" ");
                }
            }
            else
            {
                for (int i = x; i <= 0; i++)
                {
                    result.Append(i);
                    if (i < 0) result.Append(" ");
                }
            }

            return result.ToString();
        }

        // Возведение числа x в степень y
        public int Pow(int x, int y)
        {
            int result = 1;

            for (int i = 0; i < y; i++)
            {
                result *= x;
            }

            return result;
        }

        // Проверка, все ли цифры в числе одинаковы
        public bool EqualNum(int x)
        {
            int num = Math.Abs(x);

            // Однозначное число всегда имеет одинаковые цифры
            if (num < 10)
                return true;

            int lastDigit = num % 10;
            num /= 10;

            // Проверяем каждую цифру
            while (num > 0)
            {
                int currentDigit = num % 10;
                if (currentDigit != lastDigit)
                    return false;
                num /= 10;
            }

            return true;
        }

        // Отрисовка левого треугольника из звездочек
        public void LeftTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        // Игра "Угадай число"
        public void GuessGame()
        {
            Random random = new Random();
            int secretNumber = random.Next(0, 10);
            int attempts = 0;
            int userGuess;

            Console.WriteLine("Угадайте число от 0 до 9:");

            do
            {
                Console.Write("Введите число: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Вы угадали!");
                }
                else
                {
                    Console.WriteLine("Вы не угадали, введите число от 0 до 9:");
                }
            } while (userGuess != secretNumber);

            Console.WriteLine("Вы отгадали число за " + attempts + " попыток(ки)");
        }

        // Поиск последнего вхождения числа в массиве
        public int FindLast(int[] arr, int x)
        {
            // Ищем с конца массива
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        // Вставка элемента в массив на указанную позицию
        public int[] Add(int[] arr, int x, int pos)
        {
            if (pos < 0 || pos > arr.Length)
            {
                Console.WriteLine("Ошибка: позиция выходит за пределы массива!");
                return arr;
            }

            int[] newArr = new int[arr.Length + 1];

            // Копируем элементы до позиции вставки
            for (int i = 0; i < pos; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[pos] = x;

            // Копируем элементы после позиции вставки
            for (int i = pos; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }

            return newArr;
        }

        // Реверс массива (изменение порядка элементов на противоположный)
        public void Reverse(int[] arr)
        {
            // Меняем местами элементы с начала и конца
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        // Объединение двух массивов
        public int[] Concat(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];

            // Копируем первый массив
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }

            // Копируем второй массив
            for (int i = 0; i < arr2.Length; i++)
            {
                result[arr1.Length + i] = arr2[i];
            }

            return result;
        }

        // Удаление отрицательных элементов из массива
        public int[] DeleteNegative(int[] arr)
        {
            // Считаем количество неотрицательных элементов
            int count = 0;
            foreach (int num in arr)
            {
                if (num >= 0)
                    count++;
            }

            int[] result = new int[count];
            int index = 0;

            // Заполняем новый массив
            foreach (int num in arr)
            {
                if (num >= 0)
                {
                    result[index] = num;
                    index++;
                }
            }

            return result;
        }
    }
}
