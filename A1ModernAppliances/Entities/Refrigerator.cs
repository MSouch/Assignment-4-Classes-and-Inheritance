using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Entities
{
    /// <summary>
    /// Represents a refrigerator
    /// </summary>
    internal class Refrigerator : Appliance
    {
        /* Refrigerators have an Item Number, Brand, Quantity, Wattage, Color, Price, Number of Doors, Height and Width (in inches). */

        public int NumDoors { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Refrigerator(long itemnumber, string brand, int quantity, double wattage, string color, double price, int numDoors, double height, double width) : base(brand, color, price, wattage, itemnumber, quantity)
        {
            // Constructor
            NumDoors = numDoors;
            Height = height;
            Width = width;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString() + $"\nNumber of Doors: {NumDoors}\nHeight: {Height} inches\nWidth: {Width} inches";
        }
    }
}
