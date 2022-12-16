using System;

int a = int.Parse(Console.ReadLine());
if (a >= 0 && a <= 9) { a = 1; }
else if (a >= 10 && a <= 99) { a = 2; }
else if (a >= 100 && a <= 999) { a = 3; }
else if (a >= 1000 && a <= 9999) { a = 4; }
else if (a >= 10000 && a <= 99999) { a = 5; }
else if (a >= 100000 && a <= 999999) { a = 6; }

else { Console.WriteLine("Yazilan reqem MILYONDA COXDUR"); };


Console.WriteLine(a);
