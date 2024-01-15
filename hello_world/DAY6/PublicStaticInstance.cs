namespace csproject;
public class Day3_Program2
{
    static string adminName = "관리자"; // static 클래스 변수다.
    static void PubStaticInstance()
    {
        Console.WriteLine("클래스 변수와 인스턴스 변수 구별이 되나요?");
        Console.WriteLine("선생 이름을 입력해주세요 :");
        string? stName = Console.ReadLine(); // 지역변수
        if (stName == null) stName = adminName;

        Admin std = new(); // 객체 인스턴스 생성
        Admin.oldMember(stName); // 클래스 직접 접근 가능(객체생성 없이)
        Admin.temp = "임시에 접근"; // 클래스 직접 접근 가능(객체생성 없이)
        std.newMember(stName); // 학생은 직접 접근 안될까?
    }
}

class Admin
{
    public static string temp = "임시"; // static 클래스 변수다, 근데 인스턴스(객체) 마다 생성
    public void newMember(string? name)
    {
        Console.WriteLine("{0} 학생. 반갑습니다!", name);
    }

    public static void oldMember(string? name)
    {
        Console.WriteLine("{0} 선생. 반갑습니다!", name);
    }
}
