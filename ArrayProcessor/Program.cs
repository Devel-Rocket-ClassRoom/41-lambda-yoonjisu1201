using System;

// README.md를 읽고 아래에 코드를 작성하세요.
int[] numbers = { 10, 25, 7, 42, 18, 33 };
int sum = 0;
int maxValue = int.MinValue;
int minValue = int.MaxValue;
int count = 0;
int ProcessArray(int[] data, Func<int[], int> processor)
{
    return processor(data);
}
//합계 람다
ProcessArray(numbers, numbers =>
{
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
});

// 최댓값 람다
ProcessArray(numbers, numbers =>
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > maxValue)
        {
            maxValue = numbers[i];
        }
    }
    return maxValue;
});
//최솟값 람다
ProcessArray(numbers, numbers =>
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < minValue)
        {
            minValue = numbers[i];
        }
    }
    return minValue;
});
//짝수 개수 카운트 람다
ProcessArray(numbers, numbers =>
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 ==0)
        {
            count++;
        }
    }
    return count;
});


Console.WriteLine($"배열: 10, 25, 7, 42, 18, 33");
Console.WriteLine($"합계: {sum}");
Console.WriteLine($"최댓값: {maxValue}");
Console.WriteLine($"최솟값: {minValue}");
Console.WriteLine($"짝수 개수: {count}");
