using Microsoft.VisualBasic;

namespace hello_world;

// var i = 20; // unable: blocked (CS0116)
public class DAY1_Program5
{
    // var i = 20; // unable: blocked (CS0826)
    public DAY1_Program5()
    {
        var i = 20; // System.Int32?
        var st = "행복합"; // System.String?
        var d = 20.333; // System.Double?
        var st_end = "니다"; // System.String?
        // var st_end; // NULL error (CS0828)
        // var st_end = 123; // (CS0128)
        st_end = "니까?";

        Console.WriteLine("{0} " + "{1}{2}" + st_end, i, st, d);
        Console.WriteLine("Data type check: {0}", i.GetType());
        Console.WriteLine("Data type check: {0}", st.GetType());
        Console.WriteLine("Data type check: {0}", d.GetType());
    }
}