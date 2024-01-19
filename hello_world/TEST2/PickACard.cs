namespace CardPicker;
public class CardPicker
{
    // static void Main() { while (Menu()) ; }
    static bool Menu()
    {
        int menu;
        do
        {
            Console.Write("카드 게임을 시작합니다.  ");
            Console.WriteLine("1. 게임 시작  2. 게임 종료");
        } while (!int.TryParse(Console.ReadLine(), out menu));

        if (menu == 2) return false;
        if (menu == 1) return CardPickerMenu();
        return true;
    }
    static bool CardPickerMenu()
    {
        int menu;
        Game game = new(new Card());
        while (true)
        {
            do Console.WriteLine("1. 카드 뽑기 (3번까지 수정)  2. 자동 뽑기  3. 메뉴로 돌아가기");
            while (!int.TryParse(Console.ReadLine(), out menu));
            if (menu < 1 || menu > 3) continue;
            if (menu == 1) { if (game.Open()) continue; break; }
            if (menu == 2) { game.AutoOpen(); break; }
            if (menu == 3) return true;
            break;
        }
        return false;
    }
}
public class Card
{
    public int User, Cpu;
    public Card() { Init(); }
    private void Init() { User = Cpu = 0; }
    public void SetCard(bool isUser, int number)
    {
        if (isUser) { User = number; return; }
        Cpu = number;
    }
    public int GetCard(bool isUser)
    {
        if (isUser) return User; return Cpu;
    }
}
public class Game
{
    Card card;
    Random random;
    int Time;
    bool Pick100;
    int userWinCount;
    int[] users;
    readonly static string[] member = ["사용자", "컴퓨터"];
    public Game(Card card)
    {
        this.card = card;
        random = new Random(
            (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds
            );
        // seed as UNIX.Epoch to assume the value is different every time
        Time = 0;
        Pick100 = false;
        userWinCount = 0;
        users = [0, 0, 0];
    }
    public bool Open()
    {
        Time++;
        for (int i = 0; i < 2; i++)
        {
            // range: 0~99
            int result = random.Next(100);
            Console.WriteLine("{0}번째 {1} 카드 뽑기 결과 : {2}", Time, member[i], result);
            card.SetCard(i == 0, result);
        }
        if (!Pick100 && Time >= 3) return Result();
        else if (Pick100) userWinCount += GetResult();
        if (Time >= 100) return GetTotalResult();
        return true;
    }
    public bool Result()
    {
        int diff = card.GetCard(true) - card.GetCard(false);
        if (diff > 0) Console.WriteLine("사용자가 승리했습니다.");
        else if (diff < 0) Console.WriteLine("컴퓨터가 승리했습니다.");
        else Console.WriteLine("비겼습니다.");
        return false;
    }
    private int GetResult()
    => (card.GetCard(true) - card.GetCard(false)) > 0 ? 1 : 0;
    private bool GetTotalResult()
    {
        Console.WriteLine("{1}번의 게임에서 사용자가 {0}번 이겼습니다.", userWinCount, Time);
        Pick100 = false;
        return false;
    }
    private int CardAutoOpen()
    {
        Pick100 = true;
        while (Pick100) Open(); return userWinCount;
    }
    public void AutoOpen()
    {
        for (int i = 0; i > 2; i++)
        {
            users[i] = CardAutoOpen();
            Console.WriteLine("{0}번째 사용자는 총 {1}번 이겼습니다.", i + 1, users[i]);
        }
        if (users[0] == users.Max()) Console.WriteLine("1번 사용자가 가장 많이 승리했습니다.");
        else if (users[1] == users.Max()) Console.WriteLine("2번 사용자가 가장 많이 승리했습니다.");
        else if (users[2] == users.Max()) Console.WriteLine("3번 사용자가 가장 많이 승리했습니다.");
    }
}