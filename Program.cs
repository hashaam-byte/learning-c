// See https://aka.ms/new-console-template for more information
Console.WriteLine("please enter your full name");
string  name = Console.ReadLine()!;
Console.WriteLine("please enter your age");
int age = int.Parse(Console.ReadLine()!);
Console.WriteLine("please enter your test score");
double score = double.Parse(Console.ReadLine()!);
string grade = "invalid";

if (score >= 70 && score <= 100)
{
    grade = "A";
}
else if (score >= 50 && score <= 69)
{
    grade = "B";
}
else if (score >= 35 && score <= 49)
{
    grade = "C";
}
else if (score >= 0 && score <= 34)
{
    grade = "F";
}
Console.WriteLine($"Hi {name}, age {age}. \nYour score is {score}. \nYou got Grade {grade}.");
