

using ConsoleApp1;
using System.Drawing;

List<Shape> shapes = new List<Shape>();
Circle Circle= new Circle {Name = "Koło", X = 0, Y = 2, Height = 10};
Rectangle1 rectangle = new Rectangle1 { Name = "prostokąt", X = 2, Y = 2, Width = 23, Height = 23 };
Triangle triangle = new Triangle { Name = "trójkąt", X = 2, Y = 34, Height = 5, Width = 8 };

shapes.Add(triangle);
shapes.Add(Circle);
shapes.Add(triangle);
foreach (Shape shape in shapes) {
    shape.Draw(); Console.WriteLine();
}


string Pesel = "89121410146";

int rok = int.Parse(Pesel.Substring(0, 2));
int currentYear = DateTime.Now.Year;
int age = currentYear - (1900 + rok);
Console.WriteLine(age);