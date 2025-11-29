namespace _08_Indexers
{

    class Laptop
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Model : {Model} . Price : {Price}";
        }
    }
    class Shop
    {
        Laptop[] laptops;//null
        public Shop(int size)//size = 5
        {
            laptops = new Laptop[size];
        }
        public int Length
        {
            get { return laptops.Length; }
        }

        public void SetLaptop(Laptop laptop, int index) //index = 100
        {
            if (index >= 0 && index < laptops.Length)
            {
                laptops[index] = laptop;
            }
            else
            {
                throw new IndexOutOfRangeException("Incorrect index");
            }
        }
        public Laptop GetLaptop( int index) //index = 100
        {
            if (index >= 0 && index < laptops.Length)
            {
                return laptops[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Incorrect index");
            }
        }
        //Indexers
        public Laptop this[int index]//Laptop = value
        {
            get
            {
                if (index >= 0 && index < laptops.Length)
                {
                    return laptops[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Incorrect index");
                }
            }
            set
            {
                if (index >= 0 && index < laptops.Length)
                {
                    laptops[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Incorrect index");
                }

            }
        }
        public Laptop this[string model]//value
        {
            get 
            {
                foreach (var l in laptops)
                {
                    if(l.Model == model)
                        return l;
                }
                return null;
            }
            //private set
            //{
               
            //    for (var i = 0; i < laptops.Length; i++)
            //    {
            //        if(laptops[i].Model == model)
            //        {
            //            laptops[i] = value;
            //            break;
            //        }
            //    }            
            //}
        }
        private int FindByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price)
                    return i;
            }
            return -1;
        }
        public Laptop this[double price] 
        {
            get 
            { 
                int index = FindByPrice(price); 
                if(index != -1)
                {
                    return laptops[index];  
                }
                throw new Exception("Incorrect price");
            }
            set 
            {
                int index = FindByPrice(price);
                if (index != -1)
                {
                   this[index] = value;
                }
            }
        }
    }

    public class MultArray
    {
        private int[,] array;
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public MultArray(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            array = new int[rows, cols];
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set { array[r, c] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //MultArray multArray = new MultArray(2, 3);

            //for (int i = 0; i < multArray.Rows; i++)
            //{
            //    for (int j = 0; j < multArray.Cols; j++)
            //    {
            //        multArray[i, j] = i + j;//indexator - set
            //        Console.Write($"{multArray[i, j]} ");//indexator - get
            //    }
            //    Console.WriteLine();
            //}

            //numbers = 0
            //bool = false
            //references = null;
            Shop shop = new Shop(3);
            shop.SetLaptop(new Laptop() { Model = "HP", Price = 25000 }, 0);
            var laptop = shop.GetLaptop(0);
            Console.WriteLine(laptop);

            shop[1] = new Laptop() { Model = "Asus", Price = 1000 };//set
            shop[2] = new Laptop() { Model = "DELL", Price = 15000 };//set
            // value = new Laptop() { Model = "Asus", Price = 1000 }
            Console.WriteLine(shop[1]);//get

            try
            {
                for (int i = 0; i < shop.Length + 1; i++)
                {
                    Console.WriteLine(shop[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("--------------------- [string model ]-------------");
           // shop["HP"] = new Laptop() { Model = "MacBook", Price = 1000000 };
            Console.WriteLine(shop["HP"]);
            Console.WriteLine(shop["MacBook"]);

            Console.WriteLine("--------------------- [string price ]-------------");
            shop[15000.0] = new Laptop() { Model = "MacBook", Price = 1000000 };
            Console.WriteLine(shop[1000000.0]); 
           
           
        }
    }
}
