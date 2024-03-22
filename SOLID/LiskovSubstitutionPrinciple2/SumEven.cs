// namespace LiskovSubstitutionPrinciple2;
//
// public class SumEven : Sum
// {
//     public SumEven(int[] numbers) : base(numbers){}
//
//     public new int Calculate()
//     {
//         return Numbers.Where(x => x % 2 == 0).Sum();
//     }
//     
// }

using LiskovSubstitutionPrinciple2;

public class SumEven : Calculator
{
    public SumEven(int[] numbers) : base(numbers)
    {}

    public override int Calculate() => Numbers.Where(x => x % 2 == 0).Sum();

}