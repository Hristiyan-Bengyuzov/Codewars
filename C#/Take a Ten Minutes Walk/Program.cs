public class Kata
{
    public static bool IsValidWalk(string[] walk)
    {
        int defPlayerRow = 0;
        int defPlayerCol = 0;
        int finalRow = 0;
        int finalCol = 0;

        foreach (var direction in walk)
        {
            switch (direction)
            {
                case "n": finalRow--; break;
                case "s": finalRow++; break;
                case "w": finalCol--; break;
                case "e": finalCol++; break;
            }
        }

        return defPlayerRow == finalRow && defPlayerCol == finalCol && walk.Length == 10;
    }
}