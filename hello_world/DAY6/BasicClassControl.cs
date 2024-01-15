namespace csproject;
public class Day3_Program1
{
    static string adminName = "관리자";

    static void BasicClassControl()
    {
        Console.WriteLine("개선된 객체지향의 세계에 오신 것을 환경합니다");
        Console.Write("학생 이름을 입력해주세요: ");
        string? stName = Console.ReadLine();
        if (stName == null) stName = adminName;

        Student std1 = new(), std2 = new();
        std1.newMember(stName);
    }
}

class Student
{
    public void newMember(string? name)
    {
        Console.WriteLine("{0} 학생, 반갑습니다!", name);
    }
}