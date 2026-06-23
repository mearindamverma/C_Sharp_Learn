int a = 18;
int b = 6;
int c = a + b;
int e = c + c;

c = a - b; // subtraction
c = a * b; // multiplication
c = a / b; // division
e = e % c; // reminder

int d = (a + b) - 6 * c + (12 * 4) / 3 + e;
Console.WriteLine($"The value of d is {d}");

int max = int.MaxValue; //-2147483647
int min = int.MinValue; //2147483647
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

// Double
double f = 19;
double g = 23;
double h = 8;
double i = (g + f) / h;
Console.WriteLine($"the double number means it contain decimal also {i}");
double maxi = double.MaxValue;
double mini = double.MinValue;
Console.WriteLine($"The range of double is {mini} to {maxi}");
double third = 1.0 / 3.0;
Console.WriteLine($"a rounding error remains => {third}");

// Decimal
decimal minim = decimal.MinValue;
decimal maxim = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {minim} to {maxim}");
decimal k = 1.0M;   // The M suffix on the numbers indicates that a constant should use the decimal type. 
decimal l = 3.0M;   // Otherwise, the compiler assumes the double type.
Console.WriteLine(k / l);



/* 
Challang
   Write code that calculates the area of a circle whose radius is 2.50 centimeters.
   Remember that the area of a circle is the radius squared multiplied by pi. 
   One hint: the runtime contains a constant for pi: Math.PI.
   Because Math.PI is a double value, you should use double instead of decimal values for this challenge.
*/

double radius = 2.5;
double pi = Math.PI;
double Area = pi*radius*radius;

Console.WriteLine($" The area of circle is {Area}");

