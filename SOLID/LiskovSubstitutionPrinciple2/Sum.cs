// namespace LiskovSubstitutionPrinciple2;
//
// public class Sum
// {
//     protected readonly int[] Numbers;
//
//     public Sum(int[] numbers)
//     {
//         Numbers = numbers;
//     }
//
//     public int Calculate() => Numbers.Sum();
// }

using LiskovSubstitutionPrinciple2;

public class Sum : Calculator
{
    public Sum(int[] numbers) : base(numbers)
    {}

    public override int Calculate() => Numbers.Sum();

}