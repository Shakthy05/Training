// Program to Guess Secret Number (FROM LSB to MSB)
using static System.Console;

int Remainder = 0, Divisor = 2, Number = 0, Exp = 0;
for (int tries = 0; tries <= 7; tries++) {
   Write ($"Is the remainder {Remainder} when divided by {Divisor} (Y/N)? ");
   if (ReadKey ().Key == ConsoleKey.N) {
      Remainder += Divisor / 2;
      Number += (int)(1 * Math.Pow (2, Exp));
   }
   Exp++;
   Divisor = (int)Math.Pow (2, Exp + 1);
   WriteLine ();
}
WriteLine ($"\nThe Secret Number is : {Number}");

//Program to guess a number between 1 and 100 (MSB to LSB)
WriteLine ("Guess a number between 1 and 100");
WriteLine ("Is the greater than 50?(if yes press Y or press N");
int minimum = 0, maximum = 0, middle = 0;
var key = ReadKey ().Key;
if (key == ConsoleKey.Y) {
   minimum = 50; maximum = 100;
   for (int i = 0; i < 6; i++) {
      if (middle != minimum || maximum - minimum != 1) {
         middle = ((maximum + minimum + 1) / 2);
         WriteLine ($"\nIs the number greater than {middle}? (press Y for yes N for no)");
         if (ReadKey ().Key == ConsoleKey.Y) minimum = middle;
         else maximum = middle;
      }
   }
   WriteLine ($"The guessed number is {maximum}");
} else if (key == ConsoleKey.N) {
   minimum = 1; maximum = 50;
   for (int i = 0; i < 6; i++) {
      if (middle != minimum || maximum - minimum != 1) {
         middle = (maximum + minimum + 1) / 2;
         WriteLine ($"\nIs the number greater than {middle}? (press Y for yes N for no)");
         if (ReadKey ().Key == ConsoleKey.Y) minimum = middle;
         else maximum = middle;
      }
   }
   WriteLine ($"The guessed number is {maximum}");
}