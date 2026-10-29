// simple if else like python but uses semi colons and use { parenthesis for multiline } and multi conditions in ( small brackets ).
// == ; || ; && equality, or, and operators
// In order to use methods or functions use like void function (parameters) { ... }




// ExploreIf();
void ExploreIf()
{
    int a = 5;
    int b = 3;
    if (a + b > 10)
    {
        Console.WriteLine("The answer is greater than 10");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
    }

    int c = 4;
    if ((a + b + c > 10) && (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not greater than the second");
    }

    if ((a + b + c > 10) || (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not greater than the second");
    }
}


// while loop is used in the same manner like we used if before 
int counter = 0;
while (counter<5)
{
    Console.WriteLine(counter);
    counter ++;
}


// do while works in similar manner 
counter =0;
do
{
    counter++;
    Console.WriteLine(counter);
} while (counter<5); // thing to be noted the end is semi coloned


// for loop is similar first part is for initializer, second is for conditions, third is for iterator.
for (int counter1 = 0; counter1 < 10; counter1++)
{
    Console.WriteLine($"{counter1}");
}


