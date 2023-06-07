class Program
{
    static void Main()
    {
        // Отримання номера студента
        Console.Write("Введіть номер студента: ");
        int studentNumber = int.Parse(Console.ReadLine());

        // Обчислення розміру масиву
        int size = (int)(20 + 0.6 * studentNumber);

        // Створення та заповнення масиву випадковими числами
        int[] array = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(10, 101);
        }

        // Сортування масиву
        QuickSort(array, 0, size - 1);

        // Виведення відсортованого масиву
        Console.WriteLine("Відсортований масив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Введення ключового значення
        Console.Write("Введіть ключове значення: ");
        int key = int.Parse(Console.ReadLine());

        // Підрахунок кількості входжень ключового значення в масив
        int count = CountOccurrences(array, key);

        // Виведення результату
        Console.WriteLine("Кількість входжень ключового значення {0}: {1}", key, count);

        Console.ReadLine();
    }

    // Реалізація алгоритму швидкого сортування
    static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    // Реалізація підрахунку кількості входжень ключового значення
    static int CountOccurrences(int[] array, int key)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num == key)
            {
                count++;
            }
        }
        return count;
    }
}