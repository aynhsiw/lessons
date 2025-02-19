

namespace Practice
{
    public class Clothes
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }


        public string ShowText()
        {
          return Color + "," + Size + ", "+ Price;
        }
    }
}
