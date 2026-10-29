Console.WriteLine("hejjhf"); // Console: console window; WriteLine: method of console to print and then sends cursor to the next like whereas Write doesnt puts the cursor down work is same tho

string abcd = "demo";
Console.WriteLine(abcd);

abcd = "demo2";
Console.WriteLine(abcd);

Console.WriteLine("Hello " + abcd);

Console.WriteLine($"Hello {abcd}");

string bcde = "demo3";
string cdef = "demo4";

Console.WriteLine($"There was once a {abcd} that put to sale \n {bcde} and sink {cdef}");   

string greet = "    Hello World       ";

String greetTrimstart = greet.TrimStart();
Console.WriteLine($"[{greetTrimstart}]");

String greetTrimend = greet.TrimEnd();
Console.WriteLine($"[{greetTrimend}]");

Console.WriteLine($"[{greet.Trim()}]");

Console.WriteLine(greet.Replace("Hello","Yellow"));

Console.WriteLine(greet.ToLower());

Console.WriteLine(greetTrimend.ToUpper());

Console.WriteLine(greet.Contains("World       "));