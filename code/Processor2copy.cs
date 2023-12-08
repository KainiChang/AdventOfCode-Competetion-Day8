namespace code;
public class Processor2Copy
{
    public static long Process(string input)
    {
        List<char> instructions = InputHandler.ReadInputInstruction(input);
        Dictionary<string, (string, string)> maps = InputHandler.ReadInputMap(input);

        long stepCount = 0;
        List<string> startsAts = GetAllNodesEndWithA(maps);

        bool allArriveAtZ = false;
        while (!allArriveAtZ)
        {
            //pop a char from the list
            char instruction = instructions[0];
            //remove the char from the list
            instructions.RemoveAt(0);

            List<string> arrivedAts = GetArrivedAts(startsAts, instruction, maps);

            //push the char back to the tail of the list
            instructions.Add(instruction);
            stepCount++;
            Console.WriteLine("stepCount: " + stepCount
            + "---- " + string.Join(",", arrivedAts));
            if (arrivedAts.All(x => x.EndsWith('Z')))
            {
                allArriveAtZ = true;
            }

            startsAts = arrivedAts;
        }

        return stepCount;
    }
    public static List<string> GetAllNodesEndWithA(Dictionary<string, (string, string)> maps)
    {
        List<string> nodes = new List<string>();
        foreach (var map in maps)
        {
            if (map.Key.EndsWith('A'))
            {
                nodes.Add(map.Key);
            }
        }
        return nodes;
    }

    public static List<string> GetArrivedAts(List<string> startsAts, char instruction, Dictionary<string, (string, string)> maps)
    {
        var arrivedAts = new List<string>();
        foreach (var startsAt in startsAts)
        {
            if (maps.TryGetValue(startsAt, out var mapping))
            {
                string arrivedAt = instruction == 'L' ? mapping.Item1 : mapping.Item2;
                arrivedAts.Add(arrivedAt);
            }
        }
        return arrivedAts;
    }
}
