// Task 43: Write a program to find the intersection point
// two straight lines given by equations y = k1 * x + b1, y = k2 * x + b2; 
// the values ​​b1, k1, b2 and k2 are set by the user.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int PromptNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double pointB1 = PromptNumber("Enter value b1: ");
double pointK1 = PromptNumber("Enter value k1: ");
double pointB2 = PromptNumber("Enter value b2: ");
double pointK2 = PromptNumber("Enter value k2: ");

double x=(pointB2-pointB1)/(pointK1-pointK2);
double y=(pointK1*(pointB2-pointB1))/(pointK1-pointK2)+pointB1;

Console.Write($"b1 = {pointB1}, k1 = {pointK1}, b2 = {pointB2}, k2 = {pointK2} -> ({x}; {y})");
