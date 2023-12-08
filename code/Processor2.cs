namespace code;
public class Processor2
{
    public static long Process(string input)
    {
        List<char> instructions = InputHandler.ReadInputInstruction(input);
        Dictionary<string, (string, string)> maps = InputHandler.ReadInputMap(input);

        Dictionary<string, List<long>> stepCountsForTags = new Dictionary<string, List<long>>();
        long stepCount = 0;
        List<string> startsAts = GetAllNodesEndWithA(maps);

        // bool allArriveAtZ = false;
        foreach (var startsAt in startsAts)
        {
            string startTag = startsAt;
            string currentStartAt = startsAt;
            stepCount = 0;
            while (stepCount < 1000000)
            {
                //pop a char from the list
                char instruction = instructions[0];
                // Console.WriteLine("instruction: " + instruction);
                //remove the char from the list
                instructions.RemoveAt(0);
                string arrivedAt = "";
                stepCount = stepCount + 1;

                arrivedAt = GetArrivedAts(currentStartAt, instruction, maps);
                // Console.WriteLine("stepCount: " + stepCount
                // + "---- " + string.Join(",", arrivedAt));
                if (arrivedAt.EndsWith('Z'))
                {
                    if (!stepCountsForTags.ContainsKey(startTag))
                    {
                        stepCountsForTags[startTag] = new List<long>();
                    }
                    stepCountsForTags[startTag].Add(stepCount);
                }
                //push the char back to the tail of the list
                instructions.Add(instruction);
                currentStartAt = arrivedAt;
                //if the count of stepCountsForTags is larger than 30, break
                if (stepCountsForTags.ContainsKey(startTag) && stepCountsForTags[startTag].Count > 10)
                {
                    break;
                }

            }
        }
        // Print the results
        foreach (var item in stepCountsForTags)
        {
            Console.WriteLine($"{item.Key}: [{string.Join(", ", item.Value)}]");
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

    public static string GetArrivedAts(string startsAt, char instruction, Dictionary<string, (string, string)> maps)
    {
        string arrivedAt = "";

        if (maps.TryGetValue(startsAt, out var mapping))
        {
            arrivedAt = instruction == 'L' ? mapping.Item1 : mapping.Item2;
        }

        return arrivedAt;
    }
}
