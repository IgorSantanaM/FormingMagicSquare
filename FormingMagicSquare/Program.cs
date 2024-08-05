using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    static List<List<int>>[] magicSquares = new List<List<int>>[8];

    static Result()
    {
        // Precomputed 3x3 magic squares
        magicSquares[0] = new List<List<int>> { new List<int> { 8, 1, 6 }, new List<int> { 3, 5, 7 }, new List<int> { 4, 9, 2 } };
        magicSquares[1] = new List<List<int>> { new List<int> { 6, 1, 8 }, new List<int> { 7, 5, 3 }, new List<int> { 2, 9, 4 } };
        magicSquares[2] = new List<List<int>> { new List<int> { 4, 9, 2 }, new List<int> { 3, 5, 7 }, new List<int> { 8, 1, 6 } };
        magicSquares[3] = new List<List<int>> { new List<int> { 2, 9, 4 }, new List<int> { 7, 5, 3 }, new List<int> { 6, 1, 8 } };
        magicSquares[4] = new List<List<int>> { new List<int> { 8, 3, 4 }, new List<int> { 1, 5, 9 }, new List<int> { 6, 7, 2 } };
        magicSquares[5] = new List<List<int>> { new List<int> { 4, 3, 8 }, new List<int> { 9, 5, 1 }, new List<int> { 2, 7, 6 } };
        magicSquares[6] = new List<List<int>> { new List<int> { 6, 7, 2 }, new List<int> { 1, 5, 9 }, new List<int> { 8, 3, 4 } };
        magicSquares[7] = new List<List<int>> { new List<int> { 2, 7, 6 }, new List<int> { 9, 5, 1 }, new List<int> { 4, 3, 8 } };
    }

    public static int formingMagicSquare(List<List<int>> s)
    {
        int minCost = int.MaxValue;

        // Compare input matrix with all precomputed magic squares
        foreach (var magicSquare in magicSquares)
        {
            int currentCost = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    currentCost += Math.Abs(s[i][j] - magicSquare[i][j]);
                }
            }
            minCost = Math.Min(minCost, currentCost);
        }

        return minCost;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> s = new List<List<int>>();

        for (int i = 0; i < 3; i++)
        {
            s.Add(Console.ReadLine().TrimEnd().Split(' ').Select(sTemp => Convert.ToInt32(sTemp)).ToList());
        }

        int result = Result.formingMagicSquare(s);

        Console.WriteLine(result);
    }
}
