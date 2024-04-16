using System;

class SelectionSort
{
    // Metoda do generowania tablicy losowych liczb
    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100); // Zakres liczb losowych od 0 do 99
        }
        return array;
    }

    // Metoda do wyświetlania tablicy
    static void DisplayArray(int[] array, string message)
    {
        Console.WriteLine(message);
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Metoda do sortowania przez wybór
    static void SelectionSortAlgorithm(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            // Zamiana miejscami elementów
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    static void Main()
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int size = Convert.ToInt32(Console.ReadLine());

        // Generowanie tablicy losowych liczb
        int[] array = GenerateRandomArray(size);

        // Wyświetlenie tablicy przed sortowaniem
        DisplayArray(array, "Tablica przed sortowaniem:");

        // Sortowanie przez wybór
        SelectionSortAlgorithm(array);

        // Wyświetlenie tablicy po sortowaniu
        DisplayArray(array, "Tablica po sortowaniu:");
    }
}
