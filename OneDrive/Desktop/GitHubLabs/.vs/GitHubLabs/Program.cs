//int a = 18;
//int b = 6;
//int c = a / b; //+ is 24, - is 12, * is 108 / is 3.
//Console.WriteLine(c); 

//int a = 5;
//int b = 4; 
//int c = 2; 
//int d = a + b * c;
//Console.WriteLine(d); // = 13


//int a = 5;
//int b = 4;
//int c = 2;
//int d = (a + b) * c;
//Console.WriteLine(d); // = 18


//int a = 5;
//int b = 4;
//int c = 2;
//int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
//Console.WriteLine(d); //=25

//int a = 7;
//int b = 4; 
//int c = 3;
//int d = (a+b) / c;
//Console.WriteLine(d); // = 3

//int a = 7; 
//int b = 4; 
//int c = 3; 
//int d = (a + b) / c;
//int e = (a + b) % c;
//Console.WriteLine($"quotient: {d}");
//Console.WriteLine($"remainder: {e}"); //quotient: 3 remainder: 2

//int max = int.MaxValue;
//int min = int.MinValue;
//Console.WriteLine($"The range of integers is {min} to {max}"); //The range of integers is -2147483648 to 2147483647

//int what = max + 3;
//Console.WriteLine($"An example of overflow: {what}"); //The range of integers is -2147483648 to 2147483647
// An example of overflow: -2147483646


//double a = 5;
//double b = 4;
//double c = 2;
//double d = (a + b) / c;
//Console.WriteLine(d); // = 4.5 

//double a = 19;
//double b = 23;
//double c = 8;
//double d = (a + b) / c;
//Console.WriteLine(d); // = 5.35

//double max = double.MaxValue;
//double min = double.MinValue;
//Console.WriteLine($"The range of double is {min} to {max}"); 
//The range of double is -1.7976931348623157E+308 to 1.7976931348623157E+308

//double third = 1.0 / 3.0;
//Console.WriteLine(third); 
// = 0.3333333333333333

//decimal min = decimal.MinValue;
//decimal max = decimal.MaxValue;
//Console.WriteLine($"The range of the decimal type is {min} to {max}");
//The range of the decimal type is -79228162514264337593543950335 to 79228162514264337593543950335

//double a = 1.0;
//double b = 3.0;
//Console.WriteLine(a / b);
// = 0.3333333333333333

//decimal c = 1.0M;
//decimal d = 3.0M;
//Console.WriteLine(c / d);
// = 0.3333333333333333333333333333

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area); // = 19.634954084936208