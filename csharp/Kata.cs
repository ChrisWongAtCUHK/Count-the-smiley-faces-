using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
    public static int CountSmileys(string[] smileys)
    {
        return smileys.ToList<string>().Where(c => 
            {
                // Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
                // A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
                // Every smiling face must have a smiling mouth that should be marked with either ) or D
                Regex regex = new Regex(@"[:;][-~]?[)D]");
                return regex.IsMatch(c);
            }).Count();
    }
}

