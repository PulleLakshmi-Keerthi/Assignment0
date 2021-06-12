using System;

namespace RectangleProject
{
    class Program
    {
        
        
            static void Main(string[] args)
            {
               
            Rectangle Rect = new Rectangle();

                Rect.setWidth(4);
                Rect.setHeight(6);

                
                Console.WriteLine($"Total area: {Rect.getArea()}");
                Console.ReadKey();
            
        }
    }
}
