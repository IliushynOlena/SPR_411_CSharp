namespace _04_IntroOOP
{
    partial class Point //: object
    {
        //private :
        //private int number;
        //private string name;
        //private const float PI = 3.14f;
        //private readonly int id;

        //public Point()
        //{

        //    id = 10;
        //}
        //void setId(int id )
        //{
        //    this.id = id;
        //}
        static int count;
        static Point()
        {
            count = 0;
        }

        public Point() : this(0, 0) { }
      
        public Point(int x, int y)
        {
            XCoord = x; //setX(x);
            YCoord = y;//setY(y);
            count++;
        }
        //private string type;
        //public string Type { get; set; }//Auto property

        //Full property
        private string type;

        public string Type//value
        {
            get { return type; }
            set 
            { 
                if(value == "_2D_Object")
                {
                    type = value;
                }
                
            }
        }







        //properties 
        //propfull + TAB
        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //prop auto 
        //prop + TAB
        public string Name { get; set; }
        public string Color { get; set; }
        private int _xCoord;
        public int XCoord//value ==  newX
        {
            get { return _xCoord; }
            set {
                if (value > 0)
                    _xCoord = value;
                else
                    _xCoord = 0;
            }   
        }
        private int _yCoord;
        public int YCoord//value ==  newX
        {
            get { return _yCoord; }
            set
            {
                if (value > 0)
                    _yCoord = value;
                else
                    _yCoord = 0;
            }
        }
      

    }
    internal class DerivedClass : Point//public
    {

    }

    internal class Program
    {     
        static void Main(string[] args)
        {
            //Point @class = new Point();
            Point point = new Point(5,9);
            point.Print();
            Console.WriteLine(point);
            Console.WriteLine(point.ToString());

            point.setX(100);
            Console.WriteLine(point);

            point.setY(-100);
            Console.WriteLine(point.getY());
            Console.WriteLine(point);

            point.XCoord = 150;//value = 150 //setter
            int x = point.XCoord;//getter
            Console.WriteLine(x);
            Console.WriteLine(point);

        }
    }
}
