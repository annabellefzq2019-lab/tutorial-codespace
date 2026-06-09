int count = 0;

for (int a = 1; a < 21; a++)

{
    if (a % 3 == 0)
    {
        int sum = count + a;
        Console.WriteLine($"the number is {sum}");
        }
}