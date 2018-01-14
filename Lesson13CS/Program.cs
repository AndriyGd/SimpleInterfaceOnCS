﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13CS
{
    using Model;
    using Repository;

    class Program
    {
        static void Main(string[] args)
        {
            var repository = new DbRepository();
            
            //var apples = repository.GetSoldApples();
            //var apples = repository.GetApples();
            var apples = repository.GetAllApplesBy();
            ////var editApple = apples[0];
            ////PrintApple(editApple);
            ////editApple.Price = 10.45;
            ////PrintApple(editApple);

            //apples.ForEach(PrintApple);
            //repository.HistoryHelper.SaveHistory();

            //var newPrice = CurrencyConverter.Convert(apple, apple, Currency.EUR);
            //Console.WriteLine($"New price: {newPrice}");
            var apple = apples[3];
            PrintApple(apple);
            CurrencyConverter.ConvertD(apple, apple, Currency.USD);
            PrintApple(apple);
            Console.ReadKey();
        }

        private static void PrintApple(IApple apple)
        { 
            
            Console.WriteLine($"Kind: {apple.Kind}\nColor: {apple.Color}\nPrice: {apple.Price:n}\nCurrency: {apple.Currency}\n");
        }
    }
}
