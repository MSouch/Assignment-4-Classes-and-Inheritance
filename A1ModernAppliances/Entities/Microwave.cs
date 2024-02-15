using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Entities
{
    internal class Microwave : Appliance
    {
        /* Microwaves have an Item Number, Brand, Quantity, Wattage, Color, Price, Capacity and Room Type.  */

        public double Capacity { get; set; }
        public char RoomType { get; set; }




        public Microwave(long itemnumber, string brand, int quantity, double wattage, string color, double price, double capacity, string roomtype) : base(brand, color, price, wattage, itemnumber, quantity)
        {
            // Constructor
            Capacity = capacity;
            RoomType = char.Parse(roomtype);

        }

        //Methods
        public override string ToString()
        {
            string Hold = null;

            if (RoomType is 'K')
            {
                Hold = "Kitchen";
            }
            else if (RoomType is 'W')
            {
                Hold = "Work Space";
            }
            return base.ToString() + $"\nCapacity: {Capacity}\nRoom type: {Hold}";
        }
    }
}
