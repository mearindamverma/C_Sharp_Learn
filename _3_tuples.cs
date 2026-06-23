// Tuples are an ordered sequence of values with a fixed length. 
// Each element of a tuple has a type and an optional name.

var pt = (X: 1, Y: 2);
    pt.X = pt.X + 5;     // modify a tuple member

var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

// A new tuple that's a modified copy of the original using a with expression.
var pt2 = pt with { Y = 10 };
var pt3 = pt with { X = 7 };
Console.WriteLine($"The point 'pt2' is at {pt2} & {pt3}.");

// You can assign a tuple to a tuple with the same arity and types even if the members have different names.
var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine(subscript);

// You declare multiple members enclosed in parentheses. 
// All the following declarations define different tuples with different arities and member types.
var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
var person = (FirstName: "", LastName: "");
var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);


Point pt4 = new Point(1, 1);
var pt5 = pt4 with { Y = 10 };
Console.WriteLine($"The two points are {pt4} and {pt5}");
public record Point(int X, int Y);