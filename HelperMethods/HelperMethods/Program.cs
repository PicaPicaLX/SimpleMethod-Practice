using System;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");
            
            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();
            /*
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach (char item in firstNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in lastNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in cityArray)
            {
                result += item;
            }

            Console.WriteLine("Results: " + result);
            */
            Console.Write("Results: ");  // 显示"Resultes:"，然后再
            /*
            string reversedFirstName = ReverseString(firstName); // 调用下面的自定义方法"ReverseString",对变量"firstName"j
            string reversedLastName = ReverseString(lastName); // ~
            string reversedCity = ReverseString(city); // ~
            */
            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));
            Console.ReadLine();

        }


        private static string ReverseString(string message) // 自定义方法，将特定变量字符倒序,并打印在屏幕
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);
        }

        private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCity)
        {
            Console.Write(string.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }


    }
}
