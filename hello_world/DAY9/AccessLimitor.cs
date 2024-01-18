namespace csproject;
public class Day4_Program5
{
    static void Run()
    {
        PrivateClass privCl = new();
        privCl.public_method1();
        PublicClass pubCl = new();
        pubCl.name = "더 행복하세요";
    }
}
internal class PrivateClass
{
    int a = 12;
    private string name = "아저씨";
    private void private_method1() { }
    public void public_method1() { }
}
public class PublicClass
{
    internal int b = 15;
    public string name = "행복하세요";
    private void private_method2() { }
}