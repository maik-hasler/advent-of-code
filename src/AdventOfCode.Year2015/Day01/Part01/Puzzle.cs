using AdventOfCode.Abstractions;

namespace AdventOfCode.Year2015.Day01.Part01;

public sealed class Puzzle
    : IPuzzle
{
    public void Solve()
    {
        var input = File.ReadAllText("Day01/Input.txt");

        var floor = 0;

        for (var i = 0; i < input.Length; i++)
        {
            floor += input[i] == '(' ? 1 : -1;
        }

        Console.WriteLine(floor);
    }
}
