using System;

// README.md를 읽고 아래에 코드를 작성하세요.
//1.
Func<int> getnum = () => 1234;
Func<int, int> square = x => x * x;
Func<int, int, int> add = (x, y) => x + y;

Console.WriteLine(getnum());
Console.WriteLine(square(3));
Console.WriteLine(add(3, 5));

//2.
Action greet = () => Console.WriteLine("안녕하세요!");
Action<string> Hi = (msg) => Console.WriteLine("Hello, Lambda!");
Action<string, int> repeat = (msg, n) =>
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"{msg}");
    }
};

greet();
Hi("Hello, Lambda!");
repeat("반복!", 3);

//3.
Func<int, int> anonymous = delegate (int x)  {return x * x;};

Console.WriteLine(anonymous(2)); 

Func<int, int> lambda = x => x * x;

Console.WriteLine(lambda(2));

