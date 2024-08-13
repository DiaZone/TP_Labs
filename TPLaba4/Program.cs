namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь:");
            string sourcepath = Console.ReadLine();
            if (sourcepath.ToLower().Contains("https:") || sourcepath.ToLower().Contains("http:"))
            {
                Console.WriteLine("\nЗадание 1:\n");
                Console.WriteLine("Это ссылка");
                string[] names = sourcepath.Split('/', StringSplitOptions.RemoveEmptyEntries);
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("Количество уровней в структуре - {0}", names.Length - 2);
                ///2
                List<string> folder = new List<string>();
                for (int i = 1; i < names.Length - 1; i++)
                {
                    foreach (char ch in names[i])
                    {
                        if (Char.IsNumber(ch))
                        {
                            folder.Add(names[i]);
                            break;
                        }
                    }
                }
                Console.WriteLine("\n\nЗадание 2:\n");
                foreach (string name in folder)
                {
                    Console.WriteLine(name);
                }
                ///3
                Console.WriteLine("\n\nЗадание 3:\n");
                for (int i = 1; i < names.Length - 1; i++)
                {
                    foreach (char ch in names[i])
                    {
                        if ((int)ch >= 48 && (int)ch <= 57)
                        {
                            char newch = Convert.ToChar((int)ch + 17);
                            names[i] = names[i].Replace(ch, newch);
                        }
                    }
                    Console.WriteLine(names[i]);
                }
            }
            else
            {
                Console.WriteLine("\nЗадание 1:\n");
                Console.WriteLine("Это файл");
                string[] names = sourcepath.Split('\\', StringSplitOptions.RemoveEmptyEntries);
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("Количество уровней в структуре - {0}", names.Length - 1);
                ///2
                List<string> folder = new List<string>();
                for (int i = 0; i < names.Length - 1; i++)
                {
                    foreach (char ch in names[i])
                    {
                        if (Char.IsNumber(ch))
                        {
                            folder.Add(names[i]);
                            break;
                        }
                    }

                }
                Console.WriteLine("\n\nЗадание 2:\n");
                foreach (string name in folder)
                {
                    Console.WriteLine(name);
                }
                ///3
                Console.WriteLine("\n\nЗадание 3:\n");
                for (int i = 0; i < names.Length - 1; i++)
                {
                    foreach (char ch in names[i])
                    {
                        if ((int)ch>=48&&(int)ch<=57)
                        {
                            char newch = Convert.ToChar((int)ch + 17);
                            names[i] = names[i].Replace(ch, newch);
                        }
                    }
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
