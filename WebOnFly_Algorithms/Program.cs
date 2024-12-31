// See https://aka.ms/new-console-template for more information
using WebOnFly_Algorithms;

Console.WriteLine("Hello, Techie!  Your Result below ............v");
int[] input = [1, 40, 34, 21, 50, 22, 12, 9, 5];

//LargestAndSecondLargestNo.FindLargestAndSecondLargestNoInArray(input);
//LargestAndSecondLargestNo.FindLargestAndSecondLargestNoInArrayNext(input);
//LargestAndSecondLargestNo.FindLargestAndSecondLargestNoInArrayLinq(input);

//// Sorting Demo
//SortingAlgos.BubbleSort(input, input.Length);
//SortingAlgos.PrintArr(input, input.Length);

// Sum of digit 
//Console.WriteLine(SumOfDigit.SumOfDigitOfNumber(405));
//Console.WriteLine(SumOfDigit.SumOfDigitOfNumberLinq(12345));
Console.WriteLine(SumOfDigit.SumOfDigitOfNumberRecursion(12345));

