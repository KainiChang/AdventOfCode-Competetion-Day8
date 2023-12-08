namespace code;

public class InputHandler
{

    // store lines of strings in a 2d array
    public static int[,] ReadInput2DArray(string input)
    {
        // Split the input into rows
        string[] rows = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        int numRows = rows.Length;
        int numCols = rows[0].Length;
        var heightMap = new int[numRows, numCols];

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                heightMap[i, j] = rows[i][j] - '0'; // Convert char to int
            }
        }

        // // Display the 2D array for verification
        // for (int i = 0; i < numRows; i++)
        // {
        //     for (int j = 0; j < numCols; j++)
        //     {
        //         Console.Write(heightMap[i, j]);
        //     }
        //     Console.WriteLine();
        // }
        return heightMap;
    }
    public static List<char> ReadInputInstruction(string input)
    {
        // Split the input into rows
        string[] lines = input.Split(new[] { "\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

        // store line[0] as a char list
        List<char> instructions = new List<char>();
        foreach (char c in lines[0])
        {
            instructions.Add(c);
        }

        return instructions;
    }
    public static List<(string, string,string)> ReadInputMap(string input)
    {
        List<(string, string,string)> maps = new List<(string, string,string)>();

        // Split the input into rows
        string[] lines = input.Split(new[] { "\r\n\r\n", "\n\n\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        string[] mapStrings = lines[1].Split(new[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var mapString in mapStrings)
        {
            // Split each line into the three string parts
            string[] parts= mapString.Split(new[] { " ", "=","(",",",")" }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length == 3)
        {
            maps.Add((parts[0], parts[1], parts[2]));
        }
        }

        return maps;
    }
}