namespace code;
public class Processor1
{
    public static long Process(string input)
    {
        List<char> instructions = InputHandler.ReadInputInstruction(input);
        List<(string, string, string)> maps = InputHandler.ReadInputMap(input);
       
        long stepCount = 0;
        string arrivedAt = "AAA";
        while (arrivedAt != "ZZZ")
        {
            //pop a char from the list
            char instruction = instructions[0];
            //remove the char from the list
            instructions.RemoveAt(0);
            foreach (var map in maps)
            {
                if (map.Item1 == arrivedAt)
                {
                    arrivedAt = instruction == 'L' ? map.Item2 : map.Item3;
                    break;
                }
            }
            //push the char back to the tail of the list
            instructions.Add(instruction);
            // Console.WriteLine(instruction.ToString(), arrivedAt);
            //push the map back to the tail of the list
            stepCount++;
        }

        return stepCount;
    }

}
