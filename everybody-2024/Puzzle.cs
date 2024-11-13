namespace everybody_2024;

public class Puzzle
{
    public void Run(params string[] args)
    {
        if (args.Length < 1 && args.Length > 3)
        {
            throw new ArgumentException("You must provide at least one input");
        }

        switch (args.Length)
        {
            case 1:
                Console.WriteLine(Part1(args[0]));
                break;
            case 2:
                Console.WriteLine(Part1(args[0]));
                Console.WriteLine(Part2(args[1]));
                break;
            default:
                Console.WriteLine(Part1(args[0]));
                Console.WriteLine(Part2(args[1]));
                Console.WriteLine(Part3(args[2]));
                break;
        }
    }

    public virtual int Part1(string input)
    {
        return -1;
    }

    public virtual int Part2(string input)
    {
        return -1;
    }

    public virtual int Part3(string input)
    {
        return -1;
    }
}