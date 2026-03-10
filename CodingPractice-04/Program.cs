using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.
/*Action[] actions = new Action[3];

for (int i = 0; i < 3; i++)
{
    actions[i] = () => Console.Write(i);
}

foreach (Action a in actions)
{
    a();
}
Console.WriteLine();
*/
//2.
Action[] actions = new Action[3];
for (int i = 0; i < 3; i++)
{
    int loopVar = i;
    actions[i] = () => Console.Write(loopVar);
}
foreach (Action a in actions)
{
    a();
}

//3.
string[] names = { "김철수", "이영희", "박민수", "최지연" };
Array.Sort(names, (a, b) => a.Length.CompareTo(b.Length));