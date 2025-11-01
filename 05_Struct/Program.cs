using _3D_objects;

namespace _05_Struct
{
    class Point//Heap
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}";
        }
    }
    struct Square//value
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public override string ToString()
        {
            return $"Height : {Height}. Width : {Width}";
        }
    }
    class Program
    {
        static void MethodWithParams(string name, params int[] marks)
        {
            Console.WriteLine($"--------------------{name}------------");
            foreach (var mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
        static void MethodWithParams(string name,int age, params int[] marks)
        {
            Console.WriteLine($"--------------------{name}------------");
            Console.WriteLine($"--------------------{age}------------");
            foreach (var mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
        static void Modify(ref int num,ref  string str,  Point p )
        {
            num += 1;
            str += "!!!";
            p.X += 100;
            p.Y += 100;
        }
        static void GetCurrentTime(out int hour, out int minute, out int second)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            //return hour, minute, second;

        }
        static void Main(string[] args)
        {
            //new dynamic memory
            Point point = new Point(); //new - create memory scope  

            Square square = new Square();//new - invoke default constructor

            Console.WriteLine(point);
            Console.WriteLine(square);

            Point[]points = new Point[2];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
                points[i].X = int.Parse( Console.ReadLine()!);
               // points[i].X = DateTime.Parse( Console.ReadLine()!);  "2025-12-3"
            }
            







            //ref     out    params

            //out
            int h, m, s;
            //Console.WriteLine($"{h}:{m}:{s}");
            GetCurrentTime(out h, out m, out s);
            Console.WriteLine($"{h}:{m}:{s}");




            //ref - reference - посилання (& == ref)
            int number = 10;
            string str = "Hello academy";
            Point p = new Point() {  X = 3, Y = 7};
            Console.WriteLine($"Number = {number}");
            Console.WriteLine($"Str = {str}");
            Console.WriteLine($"Point = {p}");
            Modify(ref number, ref str,  p);
            Console.WriteLine($"Number = {number}");
            Console.WriteLine($"Str = {str}");
            Console.WriteLine($"Point = {p}");






            //CLR - command language runtime
            //params  == initializer_list
            int[] Olga_marks = new int[] { 10, 12, 8, 7, 4, 11 };
            MethodWithParams("Olga", Olga_marks);
            MethodWithParams("Bob", new int[] {8,8,8,8,8,8,8} );
            MethodWithParams("Tom", 1,2,3,4,5,6,7,8,9,10,12,11,12,11,3,6);



            //Point point = new Point() { X = 10, Y = 11 };
            ////point.X = 5;
            ////point.Y = 15;
            //Console.WriteLine(point);
            //_3D_objects.Point point1 = new _3D_objects.Point() { X = 10, Y = 11 };
            ////point.X = 5;
            ////point.Y = 15;
            //Console.WriteLine(point1);
        }
    }
}

namespace _3D_objects
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}. Z : {Z}";
        }
    }
}
