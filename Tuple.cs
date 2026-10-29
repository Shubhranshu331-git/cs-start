var pt = (X:12, y:23); // key value pair type
pt.X = pt.X + 5;
Console.WriteLine(pt.X);

Console.WriteLine(pt with {X = 20});   // catches the key of the var and changes the X value 

var pt2 = pt with {y=20};  
Console.WriteLine($"{pt2}");


var abcd = (a:0, b: 1);
Console.WriteLine(abcd);
abcd = pt;
Console.WriteLine(abcd);
Console.WriteLine(abcd.a);  // value of abcd with key a 


Point pt3 = new (1, 1);
var pt4 = pt3 with { Y = 10 }; // has same value as pt3 but with Y key value as 10
Console.WriteLine($"pt3 {pt3} pt4 {pt4}");
// public record Point(int X, int Y); // these are type definitions like classes in python unlike python(anywhere) it always go on the bottom of the file 

// double slopeResult = pt4.Slope();
// Console.WriteLine($"The slope of {pt4} is {slopeResult}");
// public record struct Point(int X, int Y)
// {
//     public double Slope() => (double)Y / (double)X;
// }

// public record struct Point(int X, int Y)
// {
//     public double Slope() => (double)Y / (double)X;
// } // record struct is struct type that includes extra behaviour applied to all record types 





// struct and class where class has shared reference struct has independent copy. the copy prior to it also 
// changes as the value of the current variable referenced to it changes the independent copies do not do this they are independent. 
// class is basically copy of reference.

