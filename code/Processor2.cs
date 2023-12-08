namespace code;
public class Processor2
{
    public static long Process(string input)
    {
        List<char> instructions = InputHandler.ReadInputInstruction(input);
        List<(string, string, string)> maps = InputHandler.ReadInputMap(input);

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

            if (arrivedAts.All(x => x.EndsWith('Z')))
            {
                allArriveAtZ = true;
            }

            startsAts = arrivedAts;
        }

        return stepCount;
    }
    public static List<string> GetAllNodesEndWithA(List<(string, string, string)> maps)
    {
        List<string> nodes = new List<string>();
        foreach (var map in maps)
        {
            if (map.Item1.EndsWith('A'))
            {
                nodes.Add(map.Item1);
            }
        }
        return nodes;
    }
    public static List<string> GetArrivedAts(List<string> startsAts, char instruction, List<(string, string, string)> maps)
    {
        List<string> arrivedAts = new List<string>();
        foreach (var startsAt in startsAts)
        {
            // Console.WriteLine("startsAt: " + startsAt);
            string arrivedAt = "";

            foreach (var map in maps)
            {
                if (map.Item1 == startsAt)
                {
                    arrivedAt = instruction == 'L' ? map.Item2 : map.Item3;
                    Console.WriteLine(" instruction: " + instruction + " arrivedAt: " + arrivedAt);
                    arrivedAts.Add(arrivedAt);
                    break;
                }
            }
        }
        return arrivedAts;
    }
}
