# Day 1

## Hello World
[program1](./DAY1_Program1.cs)

## Variable Types
- [VarTypes](./VarTypes.cs)
- [Constants](./Constant.cs)

## String process
- [Strings](./Strings.cs)

```cs
string x = "what";
Console.WriteLine($"{x} is shit"); // 가능
```

## Variable Types 2
- [Var-vars](./Var-vars.cs)
- [Dyn-vars](./Dyn-vars.cs)
```cs
var worker = new Worker(); // var는 이런 거 할 때나 추천 (아니면 Namespace.Class라는 형식으로 지정해야 돼서 귀찮음)
dynamic temp; // dynamic은 런타임에 해석 -> 디버깅 겁나 빡셈 -> 안 쓰는 게 좋다
// 파이썬도 타입 꼬여서 빡세잖아 여기서도 그럴거냐고
```

## Test
- [test](./Test.cs)