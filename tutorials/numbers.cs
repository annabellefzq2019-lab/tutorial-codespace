// WorkWithIntegers();
// OrderPrecedence();

//int a = 7;
//int b = 4;
//int c = 3;
//int d = (a + b) / c;
//int e = (a + b) % c;
// Console.WriteLine($"quotient: {d}");
// Console.WriteLine($"remainder: {e}");

// int max = int.MaxValue;
// int min = int.MinValue;
// Console.WriteLine($"The range of integers is {min} to {max}");

// int what = max + 3;
// Console.WriteLine($"An example of overflow: {what}");

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}


double double_max = double.MaxValue;
double double_min = double.MinValue;
Console.WriteLine($"The range of double is {double_min} to {double_max}");

decimal decimal_min = decimal.MinValue;
decimal decimal_max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {decimal_min} to {decimal_max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);