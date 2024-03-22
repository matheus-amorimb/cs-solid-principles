// using LiskovSubstitutionPrinciple2;

using LiskovSubstitutionPrinciple2;

var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Sum sum = new Sum(numbers);
// SumEven sumEven = new SumEven(numbers);
//
// Console.WriteLine($"The sum of numbers is: {sum.Calculate()}");
// Console.WriteLine($"The sum of even numbers is: {sumEven.Calculate()}");
//
// //Replacing base class for derivated class
// Sum problematicSum = new SumEven(numbers);
// //The expected value should be equal the sum of even numbers, but it is equal the sum
// Console.WriteLine($"The sum of even numbers is: {problematicSum.Calculate()}");

Calculator sum = new Sum(numbers);
Calculator sumEven = new SumEven(numbers);
//The expected value should be equal the sum of even numbers, but it is equal the sum
Console.WriteLine($"The sum of numbers is: {sum.Calculate()}");
Console.WriteLine($"The sum of even numbers is: {sumEven.Calculate()}");
