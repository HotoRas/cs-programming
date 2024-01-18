namespace csproject;
public class Day4_Program9{
    static void Run(){
        EndProgram sw = new();
        sw.init();
        sw.start();
    }
}
public class StartProgram{
    public virtual void Init(){
        Console.WriteLine("Starting program");
    }
    public void start(){
        Console.WriteLine("Start program 1");
    }
}
public class EndProgram: StartProgram{
    public override void init(){
        Console.WriteLine("Redefined");
    }
    public new void start(){
        Console.WriteLine("Start program 2");
    }
}
