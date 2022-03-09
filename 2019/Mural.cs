using System;
using System.Linq;
public static class Mural
{
    public static void Run(){
        //Read Number of Cases
        int numberOfCases = int.Parse(Console.ReadLine());

        for(int i = 1; i<= numberOfCases; i++)
        {
            int maximumBeautyScore = 0;
            int lengthOfWall = int.Parse(Console.ReadLine());
            string[] wallScoreStrings = Console.ReadLine().ToCharArray().Select(x=>x.ToString()).ToArray();
            int[] wallScores = Array.ConvertAll(wallScoreStrings, int.Parse);
            int maximumPaintableWalls = (int)Math.Ceiling(lengthOfWall/2.0);
            
            for (int index = 0; index < maximumPaintableWalls; index++)
            {
                int[] walls = wallScores.Skip(index).Take(maximumPaintableWalls).ToArray();
                int score = walls.Sum();
                maximumBeautyScore = score > maximumBeautyScore ? score : maximumBeautyScore;
            }

            Console.WriteLine($@"Case #{i}: {maximumBeautyScore}");
            Console.Out.Flush();
        }
    }
}