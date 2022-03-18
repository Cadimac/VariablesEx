using System;

namespace VariablesEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Stephen";
            int myAge =34;
            char myInitial = 's';
            bool isBored = false;
            double favoriteNumber = 3.14;
            decimal secondFavoriteNumber = 3.1415m;


            Console.WriteLine($"My name is {myName}, My age  is {myAge}. The first letter of my name is {myInitial}. Half of the time {isBored}. My favorite numbers are {favoriteNumber}, and {secondFavoriteNumber}.");


        }
    }
}
