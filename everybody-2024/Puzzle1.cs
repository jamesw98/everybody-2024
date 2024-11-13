namespace everybody_2024;

public class Puzzle1 : Puzzle
{
    public override int Part1(string input)
    {
        return input.Sum(c => c switch
        {
            'D' => 5,
            'C' => 3,
            'B' => 1,
            _ => 0
        });
    }

    public override int Part2(string input)
    {
        var total = 0;
        foreach (var chunk in input.Chunk(2))
        {
            total += Part1(new string(chunk));
            if (!chunk.Contains('x'))
            {
                total += 2;
            }
        }

        return total;
    }

    public override int Part3(string input)
    {
        var total = 0;
        foreach (var chunk in input.Chunk(3))
        {
            total += Part1(new string(chunk));
            total += chunk.Count(x => x == 'x') switch
            {
                1 => 2,
                0 => 6,
                _ => 0,
            };
        }

        return total;
    }
}