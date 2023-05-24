//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Net.Security;

//namespace povtorenie
//{
//    class povtorenie
//    {
//        static void Main()
//        {
//            //Урок 1
//            /*Console.WriteLine("Hello World!\n\n");
//            Console.Write("Hello World!3");
//            Console.Write("Hello World!2");
//            Console.ReadLine();*/

//            //Урок 2 Получение данных 

//            //int num = -10;


//            // byte num = 255;
//            // short num = 32500;
//            // int num = 22150621;
//            // long num = 900000000;

//            //float numb = 4.5f;
//            //double numb2 = 4.5d;

//            //char sym = 'A';

//            /*string word = "SUspecs";

//            bool isHappy = true;

//            Console.WriteLine(word + num + isHappy);

//            int num1 = 2, num2 = 3;

//            num1 = Convert.ToInt32(Console.ReadLine());
//            num2 = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine(num1  +  num2);*/

//            //Урок 3

//            //Console.WriteLine("Введите число");
//            //user_input = Convert.ToDouble(Console.ReadLine());
//            //float user_input = float.Parse(Console.ReadLine());
//            //float user_input = float.Parse(Console.ReadLine());

//            //float result;
//            //result = user_input + 10f;

//            //result += 5f;

//            //result++;

//            //result = user_input - 10f;
//            //result = user_input * 10f;
//            //result = user_input / 10f;
//            //result = user_input % 10f;

//            //Console.WriteLine(result);

//            //Console.WriteLine(Math.PI);
//            //Console.WriteLine(Math.Abs(-20));
//            //Console.WriteLine(Math.Ceiling(4.11));
//            //Console.WriteLine(Math.Floor(4.99));
//            //Console.WriteLine(Math.Round(4.56));

//            //Console.WriteLine(Math.Min(4, 0));
//            //Console.WriteLine(Math.Max(4, 0));
//            //Console.WriteLine(Math.Pow(4, 3));

//            //Console.WriteLine("Введите радиус: ");

//            //double radius = Convert.ToDouble(Console.ReadLine());
//            //double plosad = Math.PI * radius;
//            //Console.WriteLine("Plosad s rad {0} ravna {1}", radius, plosad);

//            // Урок 4.

//            //int a = 3;
//            ////string word = "hello";
//            //bool isHappy = false;


//            ////if (isHappy == true)
//            ////{
//            ////    Console.WriteLine("wewe");
//            ////}

//            ////if (word == "hello")
//            ////{
//            ////    Console.WriteLine("wwadawd");
//            ////}

//            //if (a == 5) {
//            //    Console.WriteLine("Number is 5");
//            //} else if  (a < 5 || isHappy){
//            //    Console.WriteLine("xexex");
//            //    //if (isHappy) 
//            //    { Console.WriteLine("popo"); }
//            //} else { 
//            //    Console.WriteLine("number ne 5"); 
//            //} 

//            // или - || , и - &&


//            // Запрашиваем у пользователя его роль и его возраст
//            //Console.WriteLine("e n");

//            //string role = Console.ReadLine();

//            //if(role == "admin")
//            //{
//            //    Console.WriteLine("e y");
//            //    int years = Convert.ToInt32(Console.ReadLine());

//            //    if (years < 0 || years > 99)
//            //    {
//            //        Console.WriteLine("Tbl debil");
//            //        Console.WriteLine("e y");
//            //        years = Convert.ToInt32(Console.ReadLine());
//            //    }
//            //}
//            //else { Console.WriteLine("Fuck y"); }

//            // Урок 5
//            //short user_input = Convert.ToInt16(Console.ReadLine());

//            //switch (user_input)
//            //{
//            //    case 0:
//            //        Console.WriteLine("Number is 0"); break;
//            //    case 1:
//            //        Console.WriteLine("Number is 1"); break;
//            //    case 2:
//            //        Console.WriteLine("Number is 2"); break;
//            //    case 3:
//            //        Console.WriteLine("Number is 3"); break;
//            //    case 4:
//            //        Console.WriteLine("Number is 4"); break;
//            //    default: 
//            //        Console.WriteLine("Number nety"); break;
//            //}

//            //Урок 6


//            //for (int i = 1000; i > 0; i -= 7)
//            //    { 
//            //        Console.WriteLine("Element {0}", i); 
//            //    }

//            //int J = 0;

//            //while (J < 10)
//            //{
//            //    J++;
//            //    Console.WriteLine(J);
//            //}


//            //bool isHasCar = true;

//            //while (isHasCar)
//            //{   
//            //    string slovo = Console.ReadLine();
//            //    if(slovo == "xui")
//            //    {
//            //        isHasCar = false;
//            //        Console.WriteLine(isHasCar);
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine(isHasCar);
//            //    }
//            //}

//            //byte i = 100;

//            //do
//            //{
//            //    Console.WriteLine(i);
//            //} while (i < 10);

//            //for (int i = 0; i < 10; i++)
//            //{
//            //    if (i > 5)
//            //        break;

//            //    if (i % 2 == 0)
//            //        continue;
//            //    Console.WriteLine(i);
//            //}


//            //Dictionary<int, string> people = new Dictionary<int, string>();

//            //var cat1 = new Dictionary<string, int>()
//            //{
//            //    ["Полосатые кошки"] = 25,
//            //    ["Чёрные кошки"] = 16,
//            //    ["Черепаховые кошки"] = 3,
//            //    ["Белые кошки"] = 1,
//            //    ["Рыжие кошки"] = 5,
//            //    ["Дымчатые кошки"] = 15,
//            //    ["Котята"] = 2
//            //};

//            //Console.WriteLine("Введите породу кота");
//            //string cat = Console.ReadLine();

//            //if (cat1.ContainsKey(cat))
//            //{
//            //    Console.WriteLine(cat1[cat]);
//            //}else
//            //{ Console.WriteLine("not found"); }


//            //урок 7

//            //byte[] nums = new byte[5];
//            //nums[0] = 250;
//            //nums[1] = 25;
//            //nums[2] = 2;
//            //nums[3] = 23;
//            //nums[4] = 243;

//            //for(int i = 0; i < nums.Length; i++)
//            //{
//            //    Console.WriteLine(nums[i]);
//            //}

//            //string[] words = new string[] {"John", "Bob", "Alex"};
//            //for (int j = 0; j < words.Length; j++)
//            //{
//            //    Console.WriteLine(words[j]);
//            //}

//            //short[] numbers = new short[10];
//            //short summa = 0;

//            //Random random = new Random();
//            //for(byte i = 0; i < numbers.Length; i++)
//            //{
//            //    numbers[i] = Convert.ToInt16(random.Next(5, 15));
//            //    Console.WriteLine(numbers[i]);

//            //    summa += numbers[i];

//            //}
//            //Console.WriteLine("summa " + summa);

//            //char[,] symbols = new char[2,3];
//            //symbols[0, 0] = 'H';
//            //Console.WriteLine(symbols[0,0]);

//            //int[,] nums = new int[,]
//            //{
//            //    {4, 6, 7},
//            //    {5, 7, 8},
//            //    {6, 8, 9}
//            //};

//            //for(int i = 0; i < nums.GetLength(0); i++)
//            //    for (int j = 0; j < nums.GetLength(1); j++)
//            //    {
//            //        Console.WriteLine(nums[i,j]);
//            //    }


//            //урок 8 

//            //short[,] nums = new short[,]
//            //{
//            //    { 5, 6, 7, 8, 9, 4, 23, 2},
//            //    { 3, 63, 71, 83, 94, 41, 233, 22}
//            //};

//            ////перебирает весь массив 
//            //foreach (short i in nums)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            //List<int> numbers = new List<int>()
//            //{
//            //    4,6,7
//            //};
//            //добавление элемента в массив
//            //numbers.Add(10);
//            //numbers.Add(100);
//            //numbers.Add(1000);
//            //удаление элемента массива по его значениею(не по его индексу)
//            //numbers.Remove(100);
//            //numbers.Sort();
//            //numbers.Reverse(); 

//            //foreach(int i in numbers)
//            //{
//            //    Console.WriteLine(i);
//            //}



//            //Урок 9
//            //Print("hello");
//            //string words = "Hello world";
//            //Print(words);

//            //int res1 = Summa(5, 6);
//            //int a = 4, b = 5;
//            //int res2 = Summa(a, b);

//            //Print(res1.ToString());
//            //Print(res2.ToString());

//            //byte[] nums = { 5, 6, 7, 8};
//            //byte res1 = Summa(nums);
//            //Console.WriteLine("Result: " + res1);

//            //byte[] nums1 = { 123, 6, 7, 8 };
//            //byte res2 = Summa(nums1);
//            //Console.WriteLine("Result: " + res2);

//            //Урок 10

//            //string word = " Hello";
//            //word += "!";

//            //word = String.Concat(word, "!");
//            //Console.WriteLine(word);

//            //Console.WriteLine(String.Compare(word, "Hello!!!"));

//            //string people = "Aex,Bob,John";
//            //string[] names = people.Split(',');
//            //people = String.Join(" ", names);
//            //foreach(string i in names) { Console.WriteLine(i); }
//            //Console.WriteLine(people);

//            //Console.WriteLine(word.Trim());
//            //Console.WriteLine(word.Substring(0,word.Length -1));

//            //Console.WriteLine(word.Length);
//            //Console.WriteLine("Ведите текст");
//            //string text = Console.ReadLine();

//            //using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate)) 
//            //{
//            //    byte[] texts = System.Text.Encoding.Default.GetBytes(text);

//            //    stream.Write(texts, 0, texts.Length);
//            //}

//            //using(FileStream stream1 = File.OpenRead("info.txt"))
//            //{
//            //    byte[] array = new byte[stream1.Length];
//            //    stream1.Read(array, 0, array.Length);
//            //    string textFromFile = System.Text.Encoding.Default.GetString(array);
//            //    Console.WriteLine(textFromFile);
//            //}

//            //Урок 11

//            //Console.WriteLine("введите число");

//            //try
//            //{
//            //    int num = Convert.ToInt32(Console.ReadLine());
//            //    Console.WriteLine(num);
//            //}
//            //catch (System.FormatException)
//            //{
//            //    Console.WriteLine("Неверный формат данных");
//            //}
//            //try
//            //{
//            //    int a, b, res;
//            //    Console.WriteLine("введите число a and b");
//            //    a = Convert.ToInt32(Console.ReadLine());
//            //    b = Convert.ToInt32(Console.ReadLine());
//            //    res = a / b;
//            //    Console.WriteLine(res);
//            //}
//            //catch (System.DivideByZeroException)
//            //{
//            //    Console.WriteLine("Делить на ноль нельзя");
//            //}
//            //catch (System.FormatException)
//            //{
//            //    Console.WriteLine("Неверный формат данных");
//            //}
//            //finally
//            //{
//            //    Console.WriteLine("Jib,jr ytne");
//            //}
//            //int b;
//            //int a = 123;
//            //string s = a.ToString();
//            //char[] ar = s.ToCharArray();
//            //Array.Reverse(ar);
//            //s = new String(ar);
//            //b = Convert.ToInt32(s);
//            //Console.WriteLine(s);
//            //Console.WriteLine(a);
//            //Console.WriteLine("Введите сумму");
//            //double sum = Convert.ToDouble(Console.ReadLine());
//            //Console.WriteLine("Введите количество месяцев");
//            //int mec = Convert.ToInt32(Console.ReadLine());  
//            //for(int i = 0; i < mec; i++)
//            //{
//            //    sum = sum + (sum / 100d * 7d);

//            //}
//            //Console.WriteLine(sum);
//            //for (int i = 1; i < 10; i++)
//            //{
//            //    for (int j = 1; j < 10; j++)
//            //    {
//            //        Console.Write($"{i * j}\t");
//            //    }
//            //    Console.WriteLine();
//            //}
//            //Console.ReadKey();
//        }
//            //Урок 9
//            //public static void Print(string word)
//            //{
//            //    Console.WriteLine(word);
//            //}

//            //public static int Summa(int x, int y)
//            //{
//            //    return x + y;
//            //}

//            //public static byte Summa(byte[] digits)
//            //{
//            //    byte summ = 0;
//            //    foreach(byte el in digits)
//            //        summ += el;
//            //    return summ;
//            //}
//        }
//}