//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


        double WorkWithUser(string message)
        {
            Console.Write(message);
            double numbers = double.Parse(Console.ReadLine());
            return numbers;
        }

        double[] GetArray(double length, double min, double max)
        {
            double[] result = new double[(int)length];
            Random rand = new Random();

            for (int i = 0; i < length; i++)
            {
                result[i] = rand.Next((int)min, (int)(max + 1)) + rand.NextDouble();
                result[i] = Math.Round(result[i],2);
            }

            return result;
        }


        void PrintArray(double[] array)
        {
            foreach (double el in array)
            {
                Console.Write(el + " ");
            }
        }

        double FindMaxValue(double[] arr)
        {
            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else continue;
            }
            return Math.Round(max,2);
        }

        double FindMinValue(double[] arr)
        {
            double min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else continue;
            }
            return Math.Round(min,2);
        }

        double size = WorkWithUser("Введите количество элементов массива: ");
        double maxValue = WorkWithUser("Введите максимальную границу диапазона  чисел: ");
        double minValue = WorkWithUser("Введите минимальную границу диапазона  чисел : ");

        double[] array = GetArray(size, minValue, maxValue);
        PrintArray(array);

        Console.WriteLine($"Разница между максимальным элементом и минимальным равна {FindMaxValue(array) - FindMinValue(array)}");
    
