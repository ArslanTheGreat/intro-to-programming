
namespace StringCalculator;
public class LinqStuff
{
    [Fact]
    public void TestLinq()
    {
        var numbers = "1,2\n3";
        var sum = numbers.Split(new char[] { ',', '\n' }).Sum(n => int.Parse(n));
        Assert.Equal(6, sum);
    }

    [Fact]
    public void TimeTravel()
    {
        // Generics provide "parametric polymorphism"
        var numbers = new List<int> { 1, 2, 3 };
        numbers.Add(4);

        var onlyTheEvens = numbers.Where(n => n % 2 == 0);

        //numbers[0] = 100; //Modify the original list after creating the LINQ query // lazy evaluation

        Assert.Equal(2, onlyTheEvens.Count()); //onlyTheEvens will only be evaluated here so it sees the modified list after the 100 change

    }
}
