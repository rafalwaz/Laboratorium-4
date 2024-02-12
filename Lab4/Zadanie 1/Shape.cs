
namespace ConsoleApp1
{
    internal class Shape
    {
        public int X { get; set; }  
        public int Y { get; set; }  
        public int Width { get; set; }  
        public int Height { get; set; }
        public string Name { get; set; }

        public virtual void Draw() {
            Console.Write("Rysuje kształt. ");
        }
    }
}
