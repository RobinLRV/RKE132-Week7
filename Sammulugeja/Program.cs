Console.WriteLine("How many steps have you walked today?");
int usersSteps = Int32.Parse(Console.ReadLine());

string result = healthmonitor(usersSteps);
Console.WriteLine(result);

static string healthmonitor(int steps)
{
    if (steps < 4000)
    {
        return "You need to move more";
    }
    else if (steps >=4000 && steps < 8000)
    {
        return "Health goal achieved.";
    }
    else
    {
        return "well done";
    }
}