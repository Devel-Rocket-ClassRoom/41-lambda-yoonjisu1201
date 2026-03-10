using System;

// README.md를 읽고 아래에 코드를 작성하세요.
var Loger1 = CreateLogger("시스템");
var Loger2 = CreateLogger("네트워크");

Loger1("서버를 시작합니다.");
Loger1("초기화가 완료되었습니다.");
Loger2("클라이언트가 접속했습니다.");
Loger1("요청을 처리합니다.");
Loger2("데이터를 수신했습니다.");
Loger2("클라이언트가 종료했습니다.");


Action<string> CreateLogger(string category)
{
    int logNumber = 0;
    return (string s) =>
    {
        logNumber++;
        Console.WriteLine($"[{category} #{logNumber}] {s}");
    };
}
