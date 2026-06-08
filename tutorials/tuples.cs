var pt = (X: 1, Y: 2);

var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.");

var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine(subscript);

var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
var namedData2 = ("Morning observation", 17, 4);
var person = (FirstName: "", LastName: "");
var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);

Console.WriteLine(namedData2);

Point pt3 = new Point(1, 1);
var pt4 = pt3 with { Y = 10 };
double slopeResult = pt4.Slope();
Console.WriteLine($"The slope of {pt4} is {slopeResult}");
Console.WriteLine($"The two points are {pt3} and {pt4}");


public record struct Point(int X, int Y)

{
    public double Slope() => (double)Y / (double)X;
}


