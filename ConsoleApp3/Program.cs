using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var output= "";
            ////output= FizzBuzz(5);
            //var message = "Hey @Joe_Bloggs what saku@gmail.com time are we meeting @FredBloggs?";
            //int position = 2;
            //output = GetRecipient(message, position);
            //int output = intre(29);
            //var output = rrution23(int[0,500,1500]);
            List<int> arr=new List<int> { 1, 1, 1, 2, 1, 3, 4 };
            goodtupless(arr.ToArray());
            //Console.WriteLine(output);

        }
        public static string GetRecipient(string message, int position)
        {
       
            string[] array1 = message.Split(' ');
            List<string> users = new List<string>();
            string username = "";
            bool isEmail = false;
            for (int i = 0; i < array1.Length; i++)
           {
                 isEmail = Regex.IsMatch(array1[i], @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);


                if (!isEmail && array1[i].StartsWith("@"))
                {

                    username = array1[i].Substring(1, array1[i].Length - 1);

                    users.Add(username.Trim(new Char[] { ' ', '*', '.', '!', '?', '/', '%', '$', '#', ',', '<', '>', '~', '@', '`' }));
                
                }
               
            }
            string use=users[position-1];
            return use;
        }

        private static string FizzBuzz(int input)
        {
            if (input < 0)
                return "Invalid input";
            if (input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (input % 3 == 0)
            {
                return "Fizz";
            }
            else if (input % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return input.ToString();
            }
        
        }

        private static int intre(int n)
        {
            string num=n.ToString();
            int num1 = int.Parse(num.Substring(0,1));
            int num2 = int.Parse(num.Substring(1,1));
            int total=num1+ num2;
            return total;

        }

        private static string[] rrution23(int[] points)
        {
            List<string> list = new List<string>();
            string[] str = new string[5];
            List<int> l = new List<int>();
            int Recruit = 0;
            int Soldier = 0;
            int Warrior = 0;
            int Captain = 0;
            int Ninja = 0;
            
            foreach (int i in points)
            {
                if (i >= 0 && i <= 999)
                {
                    ++Recruit;
                    
                }
                else if (i >= 1000 && i <= 4999)
                {
                    ++Soldier;
                    
                }
                else if (i >= 5000 && i <= 9999)
                {
                    ++Warrior;
                    
                }
                else if (i >= 10000 && i <= 49999)
                {
                    ++Captain;
                    
                }
                else if (i >= 50000)
                {
                    ++Ninja;
                   
                }

               

            }
                

            if (Recruit > 0)
                list.Add("Recruit - " + Recruit.ToString());
            if (Soldier > 0)
                list.Add("Soldier - " + Soldier.ToString());
            if (Warrior > 0)
                list.Add("Warrior - " + Warrior.ToString());
            if (Captain > 0)
                list.Add("Captain - " + Captain.ToString());
            if (Ninja > 0)
                list.Add("Ninja - " + Ninja.ToString());
            str =list.ToArray();
            return str;
        }

        /// <summary>
        /// finding good tuples of each 3 set. 2 numbers should be in each 3 number set
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private static int goodtupless(int[] a)
        {
            int[] arr = new int[3];
            int good = 0;
            for (int i = 0; i <= a.Length-3; i++)
            {
                arr = new int[3];
                for (int j = 0; j < arr.Length; j++) 
                {
                    if (i + j < a.Length)
                    {
                        arr[j] = a[i + j];
                    }
                    
                }

                if(arr[0] == arr[1] && arr[1] == arr[2])
                {
                    good = 0;
                }
                else if (arr[0] == arr[1]|| arr[0] == arr[2]|| arr[1] == arr[2])
                {
                    good++; 
                }
            }
            return good;
        }
    }
}
