
public class Calculator
{
    public int Add(string numbers)
    {
        int sum = 0;

        if (numbers == "")
        {
            return 0;
        }

        char[] delimiters = { ',', '\n' };

        var parts = numbers.Split(delimiters);


        foreach (var part in parts)
        {
            sum += int.Parse(part);
        }

        return sum;

        // One Liner
        //return numbers == "" ? 0 : numbers.Split(new char[] { ',', '\n' }).Sum(n => int.Parse(n));
    }
}
