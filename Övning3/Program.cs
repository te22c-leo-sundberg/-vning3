void Hello32()
{
    for (int i = 0; i < 32; i++)
    {
        Console.WriteLine("Hello world");
    }
}
int Squared(int f)
{
    return f*f;
}
float Multi(float f1, float f2)
{
    return f1 * f2;
}
float RightTriangleArea(float f1, float f2)
{
    return f1 * f2 / 2;
}
double CircleArea(float f1)
{
    return f1 * f1 * 3.14159265;
}
int GetNumberInput()
{
    string numInput = "";
    int numOutput = 0;
    bool success = false;
    while (!success)
    {
        numInput = Console.ReadLine();
        success = int.TryParse(numInput, out numOutput);
    }
    return numOutput;
}

int GetChoice(string[] a)
{
    bool success = false;
    string numInput = "";
    int numOutput = 0;
    // string choice = "";
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(a[i]);
    }
    while (!success)
    {
        Console.WriteLine($"Pick between option 0 and option {a.Length - 1}!");
        numInput = Console.ReadLine();
        success = int.TryParse(numInput, out numOutput);
        if (numOutput < 0 || numOutput >= a.Length)
        {
            success = false;
        }

    }
    Console.WriteLine(numInput);
    return numOutput;
}

GetChoice(["balls", "mammals", "gyatt", "rizzler", "ohio"]);

Console.ReadLine();