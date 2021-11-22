//using System.Collections.Generic;
//using System;
//using System.Text;

//namespace ConsoleApp5
//{
   





//    class Guess
//    {
//        private string answer;
//        private int a;
//        private int b;
//        private int times;


//        public string Answer { get => answer; set => answer = value; }
//        public int A { get => a; set => a = value; }
//        public int B { get => b; set => b = value; }
//        public int Times { get => times; set => times = value; }


//        public Guess(int digit = 4)
//        {
//            string number = "1234567890";

//            while (true)
//            {
//                answer = Shuffle(number).Substring(0, digit);
//                if (answer[0] != '0')
//                {
//                    break;
//                }
//                a = 0;
//                b = 0;
//                times = 0;

//            }

//            void ABCounter(string guess)
//            {
//                a = 0;
//                b = 0;
//                foreach (char i in guess)
//                {
//                    if (answer.Contains(i))
//                    {
//                        if (answer.IndexOf(i) == guess.IndexOf(i))
//                        {
//                            a += 1;
//                        }
//                        else
//                        {
//                            b += 1;
//                        }
//                    }
//                }
//            }

//             bool FindNumber(string nimber)
//            {
//                int count = 0;
//                foreach (char i in number)
//                {
//                    foreach (char j in number)
//                    {
//                        if (i == j)
//                        {
//                            count += 1;
//                        }
//                    }
//                    if (count > 1)
//                    {
//                        return true;
//                    }
//                    count = 0;
//                }
//                return false;
//            }

//            string Shuffle(string s)
//            {
//                char[] s_array = s.ToCharArray();
//                Random r = new Random();
//                int n = s.Length;
//                while (n > 1)
//                {
//                    n--;
//                    int k = r.Next(n + 1);
//                    var v = s_array[k];
//                    s_array[k] = s_array[n];
//                    s_array[n] = v;
//                }
//                return new string(s_array);
//            }

//             void Run()
//            {
//                times = 0;
//                while (true)
//                {
//                    times += 1;
//                    string userinput = Console.ReadLine();
//                    if (userinput.Length != 4)
//                    {
//                        Console.WriteLine("長度不符");
//                        continue;
//                    }
//                    if (FindNumber(userinput))
//                    {
//                        Console.WriteLine("重複數字");
//                        continue;
//                    }
//                    ABCounter(userinput);
//                    if (a == 4)
//                    {
//                        Console.WriteLine("猜中!一共猜了{0}次", times);
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("{0}A{0}B", a, b);
//                    }

//                }
//            }
//        }


//    }
   
//}