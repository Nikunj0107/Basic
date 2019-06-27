using System;

public class Program
{
    public static void Main()
    {
        int i = 2;

        // the switch statement contains the condition (i)
        switch (i)
        {
            // each case contains an evaluation criteria 
            case 1:
                Console.WriteLine("i=1");
                break;
            case 2:
                Console.WriteLine("i=2");
                break;
            case 3:
                Console.WriteLine("i=3");
                break;
            // if none of the conditions are met the 'default' (optional) statement is executed
            default:
                Console.WriteLine("i is not 1,2, or 3");
                break;
        }


        // the switch statement contains the condition (i)
        switch (i)
        {
            // each case contains an evaluation criteria
            // notice the empty case statements are allowed to fall through to the next
            // 		(e.g. no break statement)
            case 1:
            case 2:
            case 3:
                Console.WriteLine("i<=3");
                break;
        }
    }
}