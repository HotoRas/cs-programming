namespace hello_world;

public class Exam
{
    public Exam()
    {
        string
        a = "바나나",
        b = "딸기",
        name = "명수";
        int
        banana = 10,
        strawberry = 5;

        Console.WriteLine("{0}야, 배고프니?", name);
        Console.WriteLine($"{name}가 훔쳐 먹은 {a}는 {banana}개 {b}는 {strawberry}개로 과일을 총 {banana + strawberry}개를 먹었습니다.");
    }
}