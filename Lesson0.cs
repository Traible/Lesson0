using System.Buffers;
using System.Collections;
using System.Xml.Linq;
// using ClassForInteger;
// bool SortCheck = false;

List<int> Array = new List<int>();

//    for (int i = 4; i < 8; i++)
//    Array.Add(i);

//IntegerArray.Add(Array);

// IntegerArray Array = new IntegerArray();

int? GetMax()
{
    if (Array.Count > 0)
    {
        int Max = Array[0];
        for (int i = 1; i < Array.Count; i++)
        {
            if (Array[i] > Max)
                Max = Array[i];
        }
        return Max;
    } return null;
}

int? GetMin()
{
    if (Array.Count > 0)
    {
        int Min = Array[0];
        for (int i = 1; i < Array.Count; i++)
        {
            if (Array[i] < Min)
                Min = Array[i];
        }
        return Min;
    }
    return null;
}


while (true)
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1. Добавить элемент");
    Console.WriteLine("2. Удалить один элемент");
    Console.WriteLine("3. Удалить все вхождения данного элемента");
    Console.WriteLine("4. Вывести на экран");
    Console.WriteLine("5. Очистить весь список");
    Console.WriteLine("6. Отсортировать имеющийся список в порядке возрастания");
    Console.WriteLine("7. Отсортировать в порядке убывания");
    Console.WriteLine("8. Найти все элементы в заданном диапазоне");
    Console.WriteLine("9. Показать уникальные элементы");
    Console.WriteLine("10. Показать элементы, которые встречаются n раз");
    Console.WriteLine("11. Посчитать сумму всех элементов");
    Console.WriteLine("12. Найти медиану");
    Console.WriteLine("13. Найти среднее значение");
    Console.WriteLine("14. Найти минимальный элемент");
    Console.WriteLine("15. Найти максимальный элемент");
    Console.Write("\nВыбор: ");

    string inputString = Console.ReadLine();
    try
    {
        string Выбор = inputString;

        switch (Выбор)
        {
            case "1":
                {
                    string? input = Console.ReadLine();
                    bool result = int.TryParse(input, out var temp);
                    if (result == true)
                        Array.Add(temp);
                    else
                        Console.WriteLine("Некоректный ввод.");
                    break;
                }
            case "2":
                {
                    if (Array.Count != 0)
                    {
                        string? input = Console.ReadLine();
                        bool result = int.TryParse(input, out var temp);
                        if (result != true)
                        {
                            Console.WriteLine("Некоректный ввод.");
                            break;
                        }
                        else
                            for (int i = 0; i < Array.Count; i++)
                            {
                                if (Array[i] == temp)
                                    {
                                        Array.Remove(temp);
                                        break;
                                    }
                                }
                            }
                    else Console.WriteLine("Список пуст.");
                    break;
                }
            case "3":
                {
                    if (Array.Count != 0)
                    {
                        string? input = Console.ReadLine();
                        bool result = int.TryParse(input, out var temp);
                        if (result != true)
                        {
                            Console.WriteLine("Некоректный ввод.");
                            break;
                        }
                        else
                            for (int i = 0; i < Array.Count; i++)
                            {
                                if (Array[i] == temp)
                                {
                                    Array.Remove(temp);
                                    i--;
                                }
                            }
                    }
                    else Console.WriteLine("Список пуст.");
                    break;
                }
            case "4":
                {
                    if (Array.Count != 0)
                    {
                        for (int i = 0; i < Array.Count; i++)
                            Console.WriteLine(Array[i]);
                    }
                    else Console.WriteLine("Список пуст.");
                    break;
                }
            case "5":
                {
                    if (Array.Count != 0)
                    {
                        Array.Clear();
                        Console.WriteLine("Список пуст.");
                    }
                    else Console.WriteLine("Список был пуст.");
                    break;
                }
            case "6":
                {
                    //  Отсортировать имеющийся список в порядке возрастания
                    if (Array.Count != 0) 
                    {
                        int temp;
                        for (int i = 0; i < Array.Count - 1; i++)
                        {
                            for (int j = i + 1; j < Array.Count; j++)
                            {
                                if (Array[i] > Array[j])
                                {
                                    temp = Array[i];
                                    Array[i] = Array[j];
                                    Array[j] = temp;
                                }
                            }
                        }
                    }
                    else Console.WriteLine("Нечего сортировать.");
                    break;
                }
            case "7":
                {
                    //  Отсортировать имеющийся список в порядке убывания
                    if (Array.Count != 0)
                    {
                        int temp;
                        for (int i = 0; i < Array.Count - 1; i++)
                        {
                            for (int j = i + 1; j < Array.Count; j++)
                            {
                                if (Array[i] > Array[j])
                                {
                                    temp = Array[i];
                                    Array[i] = Array[j];
                                    Array[j] = temp;
                                }
                            }
                        }
                        Array.Reverse();
                    }
                    else Console.WriteLine("Нечего сортировать.");
                    break;
                }
            case "8":
                {
                    //  Найти все элементы в заданном диапазоне
                    if (Array.Count != 0)
                    {
                        int? Max;
                        int? Min;

                        Console.WriteLine("Введите элемент А, для поиска по диапазону: ");
                        string? input1 = Console.ReadLine();
                        bool result1 = int.TryParse(input1, out var temp1);
                        if (result1 == true)
                            Min = temp1;
                            else
                            {
                             Console.WriteLine("Некоректный ввод, попробуйте заново!");
                             break;
                            }

                        Console.WriteLine("Введите элемент B, для поиска по диапазону: ");
                        string? input2 = Console.ReadLine();
                        bool result2 = int.TryParse(input2, out var temp2);
                        if (result2 == true)
                            Max = temp2;
                            else
                                {
                                    Console.WriteLine("Некоректный ввод, попробуйте заново!");
                                    break;
                                }
                        if (Max != null && Min != null)
                            {
                            if (Max < Min)
                            {
                                int? temp = Max;
                                Max = Min;
                                Min = temp;
                            }
                            for (int i = 0; i < Array.Count; i++)
                                if (Array[i] >= Min && Array[i] <= Max)
                                    Console.WriteLine(Array[i]);
                        }
                    }
                    else Console.WriteLine("Массив пуст.");
                    break;
                }
            case "9":
                {
                    // Показать уникальные элементы
                    if (Array.Count != 0)
                    {
                        int Check = 0;
                        for (int i = 0; i < Array.Count; i++)
                        {
                            for (int j = 0; j < Array.Count; j++)
                            {
                                if (Array[i] == Array[j])
                                    Check++;
                            }
                            if (Check == 1)
                            {
                                Console.WriteLine(Array[i]);
                                Check = 0;
                            }
                        }
                    }
                    else Console.WriteLine("Список пуст.");
                    break;
                }
            case "10":
                {
                    // Показать элементы которые встречаются N раз
                    if (Array.Count != 0)
                    {
                        int SuccesCheck = 0;
                        Console.WriteLine("Введите количество повторений искомого элемента: ");
                        string? input = Console.ReadLine();
                        bool result = int.TryParse(input, out var temp);
                        if (result != true)
                        {
                            Console.WriteLine("Некоректный ввод.");
                            break;
                        }
                        else
                        {
                            int Check = 0;
                            for (int i = 0; i < Array.Count; i++)
                            {
                                for (int j = 0; j < Array.Count; j++)
                                {
                                    if (Array[i] == Array[j])
                                        Check++;
                                }
                                if (Check == temp)
                                {
                                    Console.WriteLine(Array[i]);
                                    Check = 0;
                                    SuccesCheck++;
                                }
                                Check = 0;
                            }
                            if (SuccesCheck == 0)
                                Console.WriteLine("Подобных элементов не найдено!");
                        }
                    }
                    else Console.WriteLine("Список пуст.");
                    break;
                }
            case "11":
                {
                    // Посчитать сумму всех элементов
                    if (Array.Count != 0)
                    {
                        int Temp = 0;
                        for (int i = 0; i < Array.Count; i++)
                        {
                            Temp += Array[i];
                        }
                            Console.WriteLine(Temp);
                    }
                    else Console.WriteLine("Список пуст.");
                    break;
                }
            case "12":
                {
                    // Найти медиану
                    if (Array.Count != 0)
                    {
                        float Temp = Array.Count;
                        float Middle = 0;
                        float temp1 = Temp / 2;
                        int temp2 = Array.Count / 2;
                        if (temp1 == temp2)
                        {
                            for (int i = ((Array.Count + 1) / 2) - 1, j = 0; j < 2; j++,i++)
                            {
                                Middle += Array[i];
                            }
                            Middle = Middle / 2;
                        }
                        else
                        {
                            Middle = Array[Array.Count / 2];
                        }
                        Console.WriteLine(Middle);
                    }
                    else Console.WriteLine("Список пуст.");
                    break;
                }
            case "13":
                {
                    // Посчитать среднее значение
                    if (Array.Count != 0)
                    {
                        float Temp = 0;
                        float Average;
                        for (int i = 0; i < Array.Count; i++)
                        {
                            Temp += Array[i];
                        }
                        Average = Temp / Array.Count;
                        Console.WriteLine(Average);
                    }
                    else Console.WriteLine("Список пуст.");
                    break;
                }
            case "14":
                {
                    //  Найти минимальный элемент
                    if (Array.Count == 1)
                    {
                        Console.WriteLine(Array[0]);
                        break;
                    }
                    else if (Array.Count >= 2)
                        Console.WriteLine(GetMin());
                    else Console.WriteLine("Невозможно выбрать");
                    break;
                }
            case "15":
                {
                    // 15.Найти максимальный элемент
                    if (Array.Count == 1)
                    {
                        Console.WriteLine(Array[0]);
                        break;
                    }
                    else if (Array.Count >= 2)
                        Console.WriteLine(GetMax());
                    else Console.WriteLine("Невозможно выбрать");
                    break;
                }
            default:
                {
                    Console.WriteLine("Такой вариант не предусмотрен.");
                    break;
                }
        }
        Console.WriteLine("Нажмите любую клавишу для продолжения...");
        Console.ReadLine();
    }
    finally
    {
        Console.Clear();
    }
}

