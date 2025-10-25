namespace _04_IntroOOP
{
    partial class Point
    {
        public void Print()
        {
            Console.WriteLine($"X : {_xCoord}. Y : {_yCoord}");
        }
        public override string ToString()
        {
            return $"X : {_xCoord}. Y : {_yCoord}";
        }
    }
}
