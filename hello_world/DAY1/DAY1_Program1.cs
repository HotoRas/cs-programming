namespace hello_world1
{

    /*public*/
    class DAY1_Program1
    {
        public DAY1_Program1()
        {
            string man = "아저씨1";
            Console.WriteLine("Hello, World!");
            Console.WriteLine(man);
        }
    }
}

namespace hello_world2
{
    class DAY1_Program1
    {
        /// <summary>
        /// 뷁
        /// </summary>
        /// <param name="args">main의 그거</param>
        public DAY1_Program1(string[] args)
        {
            string man = "아저씨2";
            Console.WriteLine("Hello, World2!");
            Console.WriteLine(man);
            var test = new hello_world1.DAY1_Program1();
        }
    }
}