﻿//Program.cs
//CHOCOLATE WRAPPERS
//Program to find the maximum number of chocolates that can get along with any unused money X and wrappers W
//Given money X , along with price P of a chocolate and required wrappers W for a chocolate in exchange.
//Sample Input :X = 15, P = 4, W = 3
// Sample Output :C = 4, X = 3, W = 1
using static System.Console;
while (true) {
   Write ("Enter the amount to buy chocolates: ");
   if (!int.TryParse (ReadLine (), out int money) || money <= 0) {
      Write ("Enter valid money\n");
      continue;
   } else {
      while (true) {
         Write ("Enter the price of a chocolate: ");
         if (!int.TryParse (ReadLine (), out int priceofChocolate) || priceofChocolate <= 0) {
            Write ("Enter valid price for a chocolate\n");
            continue;

         } else {
            while (true) {
               Write ("Enter the number of wrappers in exchange for a chocolate: ");
               if (!int.TryParse (ReadLine (), out int wrappers) || wrappers <= 0) {
                  Write ("Enter valid number of wrappers\n");
                  continue;
               } else if (money >= priceofChocolate) {
                  var result = GetMaxChoc (money, priceofChocolate, wrappers);
                  Write ($"\nTotal number of chocolates purchased and obtained in exchange for wrappers: {result.MaxChoc}\nThe amount remaining after the purchase: {result.Money}\nThe wrappers remaining after the purchase: {result.Wrappers}\n");
                  break;
               } else {
                  Write ("The Money is too Low.");
                  break;
               }
            }
         }
         break;
      }
   }
   break;
}
/// <summary>This method returns a tuple with maximum chocolate for the given money with remaining money and remaining wrappers</summary>
/// <param name="a">This is the money available</param>
/// <param name="b">This is the price of a chocolate</param>
/// <param name="c">This is the number of wrappers exchanges for a chocolate</param>
(int MaxChoc, int Money, int Wrappers) GetMaxChoc (int a, int b, int c) {
   int maxchoc = a / b, money = a % b, wrappers = maxchoc, extrachoc = 0;
   while (wrappers >= c) {
      for (; wrappers >= c; wrappers -= c) {
         maxchoc++;
         extrachoc++;
      }
      wrappers += extrachoc;
      extrachoc = 0;
   }
   return (maxchoc, money, wrappers);
}