
using CircleObjects;

//maincode

Circle myCircle = new Circle(Welcome());
Console.WriteLine(Formulas(myCircle));


while (YesOrNo())
{
    Console.WriteLine("The circle is magically growing");
    myCircle.Grow();
    Console.WriteLine(Formulas(myCircle));
   
}
    Console.WriteLine($"Goodbye! The circle's final radius is {myCircle.GetRadius()}");


//methods
static double Welcome() 
{
    Console.WriteLine($"*.*.*Magic Circle Grower*.*.*");
    Console.Write("Enter Radius: ");
    double input; 
    while(!double.TryParse(Console.ReadLine(), out input)) {
        Console.WriteLine("Must be a number. Try Again.");
    }
    return input;
}

static bool YesOrNo()
{
    while (true)
    {
        Console.WriteLine("Should we use a little magic and have your circle grow? y/n");
        string choice = Console.ReadLine().Trim().ToLower();
        if (choice == "y")
        {
            return true;
        }
        else if (choice == "n")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Invalid Input. Please try again.");
        }
    }
}


static string Formulas(Circle circle)
{
    return $"Diameter: {circle.CalculateDiameter()}\n" +
           $"Circumference: {circle.CalculateCircumference()}\n" +
           $"Area: {circle.CalculateArea()}\n";
}
