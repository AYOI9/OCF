Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
        int maxDigit = 0;
        for (int i = 10; i <= N; i++)
        {
            int number = i;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
                number /= 10;
            }
        }

        Console.WriteLine(maxDigit);
