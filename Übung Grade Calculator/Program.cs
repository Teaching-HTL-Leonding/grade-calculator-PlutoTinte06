int possible_points = 80;
int grade = 0;
double percentage = 0;
string answer;
int points1 = 0;
int points2 = 0;
int homework = 0;
int oral = 0;

Console.Clear();

Console.WriteLine("Did you participate on the first exam?");
answer = (Console.ReadLine()!);

if (answer == "yes")
{
    Console.WriteLine("How many points did you get?");
    points1 = int.Parse(Console.ReadLine()!);
}
else { possible_points -= 20; }

Console.WriteLine("Did you participate on the second exam?");
answer = (Console.ReadLine()!);

if (answer == "yes")
{
    Console.WriteLine("How many points did you get?");
    points2 = int.Parse(Console.ReadLine()!);
}
else { possible_points -= 20; }

Console.WriteLine("How many points did you get on your homework");
homework = int.Parse(Console.ReadLine()!);

Console.WriteLine("Did you participate on the oral exam?");
answer = (Console.ReadLine()!);
if (answer == "yes")
{
    Console.WriteLine("How many points did you get?");
    oral = int.Parse(Console.ReadLine()!);
}
else { possible_points -= 20; }

percentage = 100d * (points1 + points2 + homework + oral) / possible_points;

if (percentage < 50) { grade = 5; }
if (percentage >= 50) { grade = 4; }
if (percentage >= 63) { grade = 3; }
if (percentage >= 76) { grade = 2; }
if (percentage >= 89) { grade = 1; }

Console.WriteLine("Your grade is " + grade + ".");
Console.ReadKey();
Console.Clear();