// Task 21. Write a program that takes as input coordinates
//  of two points and finds the distance between them in 3D space.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    Console.Write("distance between coordinates: ");
    double result1 = (x2 - x1) * (x2 - x1);
    double result2 = (y2 - y1) * (y2 - y1);
    double result3 = (z2 - z1) * (z2 - z1);
    double result = Math.Sqrt(result1 + result2 + result3);
    Console.Write(Math.Round(result, 2));
}
double GetDouble(string text)
{
    Console.Write(text);
    double num = double.Parse(Console.ReadLine());
    return num;
}
// data (first&second points) input from User 
double x1 = GetDouble("Enter x1: ");
double y1 = GetDouble("Enter y1: ");
double z1 = GetDouble("Enter z1: ");
double x2 = GetDouble("Enter x2: ");
double y2 = GetDouble("Enter y2: ");
double z2 = GetDouble("Enter z2: ");

Distance(x1, y1, z1, x2, y2, z2);