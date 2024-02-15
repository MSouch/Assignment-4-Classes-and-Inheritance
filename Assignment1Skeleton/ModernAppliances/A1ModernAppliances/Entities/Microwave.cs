using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Entities
{
    internal class Microwave : Appliance
    {
        /* Microwaves have an Item Number, Brand, Quantity, Wattage, Color, Price, Capacity and Room Type.  */

        public double Capacity { get; set; }
        public string RoomType { get; set; }




        public Microwave(int itemnumber, string brand, int quantity, double wattage, string color, double price, double capacity, string roomtype) : base(brand, color, price, wattage, itemnumber, quantity)
        {
            // Constructor
            Capacity = capacity;
            RoomType = roomtype;

        }

        //Methods
        public override string ToString()
        {
            if (RoomType is "K")
            {
                RoomType = "Kitchen";
            }
            else if (RoomType is "W")
            {
                RoomType = "Work Space";
            }
            return base.ToString() + $"\nCapacity: {Capacity}\nRoom type: {RoomType}";
        }
    }
}
