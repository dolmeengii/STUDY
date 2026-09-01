using System.Diagnostics;

class Program
{
    static void Main ()
    {
        string str = "*";

        int a = 1;
        int b = 10;

        int result=0;

        switch (str)
        {
            case "+": 
            result = a+b;
            break;

            case "-":
            result = a-b;
            break;

            case "*":
            result = a*b;
            break;

            case "/":
            result = a/b;
            break;

            default:
            break;
        }

        Console.WriteLine(result);
    }
}