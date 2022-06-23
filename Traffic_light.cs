using System;
public class Kata
{
    public static string UpdateLight(string current)
    {
        if (current == ("green"))
        {
            return ("yellow");
        }
        else if (current == ("yellow"))
        {
            return ("red");
        }
        else
        {
            return ("green");
        }
    }
}