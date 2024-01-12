namespace csproject;
public class Week1_Test1
{
    static void Main() { MainLoop(); }

    /// <summary>
    /// Main program loop.
    /// 프로그램 메인 영역.
    /// </summary>
    public static void MainLoop()
    {
        string member_id = string.Empty;
        Flush(ref member_id);

        while (!GetMemberCode(ref member_id)) ; // Main routine
    }

    /// <summary>
    /// Get member ID and have validation.<br />
    /// 주민번호를 가져와 검증합니다.
    /// </summary>
    /// <param name="member">Reference string that it will process.
    /// Always be "000000-0000000" (default) when
    /// the method returns.<br />
    /// 가지고 작업할 string 레퍼런스입니다.
    /// 메서드가 리턴할 때에는 항상 "000000-0000000" (초기 값)으로
    /// 변경됩니다.</param>
    /// <returns>if the entered ID is valid, returns true.
    /// else it returns false.</returns>
    public static bool GetMemberCode(ref string member)
    {
        // Read member id
        Console.WriteLine("주민등록번호를 입력해주세요.");
        Console.WriteLine("형식:\n\t112233-4567890\n\t1122334567890\n\t112233 4567890");
        Console.Write("-> "); member = Console.ReadLine();

        // False if blank
        if (string.IsNullOrWhiteSpace(member))
        {
            Console.WriteLine("아무 것도 입력되지 않았습니다.");
            return false;
        }
        return PrintMemberCode(ref member);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="member">Reference string that it will process.
    /// Always be "000000-0000000" (default) when
    /// the method returns.<br />
    /// 가지고 작업할 string 레퍼런스입니다.
    /// 메서드가 리턴할 때에는 항상 "000000-0000000" (초기 값)으로
    /// 변경됩니다.</param>
    /// <returns>if the entered ID is valid, returns true.
    /// else it returns false.</returns>
    private static bool PrintMemberCode(ref string member)
    {
        // Split member id
        string[] member_arr;
        if (!int.TryParse(member[7].ToString(), out int dummy))
            member_arr = member.Split('-', ' ');
        else
            member_arr = [member[..6], member[6..]]; // substring

        // validate length and is null in case of buggy interpreter
        if (member_arr[0] == null || member_arr[0].Length != 6 // yymmdd
            || member_arr[1] == null || member_arr[1].Length != 7) // GabcdeV
        {
            Console.WriteLine("형식에 맞지 않습니다. 다시 입력해주세요.");
            Flush(ref member);
            return false;
        }

        if (!ValidateDate(member_arr[0]))
        {
            Console.WriteLine("주민등록번호의 날짜 형식이 맞지 않습니다. 다시 입력해주세요.");
            Flush(ref member);
            return false;
        }

        // validate if all intager
        foreach (char c in member) // less mem., less time
        {
            if (!int.TryParse(c.ToString(), out dummy))
            {
                Console.WriteLine("형식에 맞지 않습니다. 다시 입력해주세요.");
                Flush(ref member);
                return false;
            }
        }

        // flush source data first
        Flush(ref member);

        // print masked member id: not modifying the copied array to further validating the id
        Console.WriteLine($"입력한 주민등록번호: {member_arr[0]}{'*' * member_arr[1].Length}");

        // validate the id
        return ValidateMemberCode(member_arr[0] + member_arr[1]);
    }

    /// <summary>
    /// Validate member ID with fomula.<br />
    /// 공식에 따라 주민등록번호를 검증합니다.<br /><br />
    /// Fomula:<code>1. add the sequence: 234567892345: to each number of ID.<br />
    /// 2. have the sum of them, and grab the leftover with dividing into 11.<br />
    /// 3. sub the leftover from 11, and check with the last digit.</code>
    /// </summary>
    /// <param name="member">member ID string with 13-digit number<br />
    /// 13자리의 숫자로 된 주민등록번호 스트링</param>
    /// <returns>if the entered ID is valid, returns true.
    /// else it returns false.</returns>
    private static bool ValidateMemberCode(string member)
    {
        // split every byte of member to intager
        int[] memberIdArr = [];
        for (int i = 0; i < 13; i++)
        {
            int.TryParse(member[i].ToString(), out memberIdArr[i]);
        }
        // int valCode = memberIdArr[12];

        bool isW = int.IsEvenInteger(memberIdArr[6]); // odd -> Men; even -> Women;

        // Checksum
        int sum = 0; int[] valData = [2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5];
        for (int i = 0; i < 12; i++)
        {
            sum += memberIdArr[i] * valData[i];
        }

        if (11 - (sum % 11) == memberIdArr[12])
        {
            Console.WriteLine("정상 주민등록번호입니다. 성별: {0}", isW ? "여자" : "남자");
            return true;
        }

        Console.WriteLine("주민등록번호가 틀립니다.");
        return false;
    }

    /// <summary>
    /// Reset the id string to its default value.<br />
    /// 주민번호 string을 초기화합니다.<br /><br />
    /// Default: <code>"000000-0000000"</code>
    /// </summary>
    /// <param name="s">Reference string to reset.<br />
    /// 초기화할 스트링 레퍼런스입니다.</param>
    private static void Flush(ref string s)
    {
        s = "000000-0000000";
    }

    /// <summary>
    /// Validate the date string if it's valid.<br />
    /// 날짜 스트링이 유효한지 확인합니다.
    /// </summary>
    /// <param name="date">Date string to be checked.<br />
    /// 확인할 날짜 스트링.</param>
    /// <returns>if the date is valid, returns true.
    /// else returns false.</returns>
    private static bool ValidateDate(string date)
    {
        int.TryParse(date[0..1], out int yy);
        int.TryParse(date[2..3], out int mm);
        int.TryParse(date[4..5], out int dd);

        bool Feb29 = yy % 4 == 0 && (yy % 100 != 0 || yy % 400 == 0);

        if (mm > 12) return false; // 모든 년도: 12를 초과하지 않음

        if (mm * dd == 0) return false; // 월, 일은 0일 수 없음

        if (dd > 31) return false; // 모든 월: 31을 초과하지 않음
        if (mm == 2) if (dd > (Feb29 ? 29 : 28)) return false; // 2월 확인
        if (mm == 4 || mm == 6 || mm == 9 || mm == 11) if (dd > 30) return false; // 30일인 월 확인

        return true;
    }
}