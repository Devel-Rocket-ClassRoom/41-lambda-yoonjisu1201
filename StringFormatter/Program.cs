using System;
using System.Runtime.Serialization;

// README.md를 읽고 아래에 코드를 작성하세요.

Func<string, string> toUpper = msg => msg.ToUpper();
Func<string, string> mask = msg => msg.Substring(0, 2) + "***";
Func<string, string> greet = msg => "안녕하세요, " + msg + "님!";

Console.Write($"[대문자 변환] hello world → ");
ApplyAndPrint("hello world", toUpper);
Console.Write($"[마스킹 처리] SecretCode → ");
ApplyAndPrint("SecretCode", mask);
Console.Write($"[인사말 생성] 민수 → ");
ApplyAndPrint("민수", greet);

void ApplyAndPrint(string input, Func<string, string> formatter)
{
    Console.WriteLine(formatter(input));
}