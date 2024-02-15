namespace ModernAppliances.Entities.Abstract
{
    /// <summary>
    /// Abstract representation of an appliance
    /// </summary>
    internal abstract class Appliance
    {
        /* 
         •	Refrigerators have an Item Number, Brand, Quantity, Wattage, Color, Price,  || Number of Doors, Height and Width (in inches). 
         •	Vacuums have an Item Number, Brand, Quantity, Wattage, Color, Price,        || Grade and Battery Voltage. 
         •	Microwaves have an Item Number, Brand, Quantity, Wattage, Color, Price,     || Capacity and Room Type. 
         •	Dishwashers have an Item Number, Brand, Quantity, Wattage, Color, Price,    || Sound Rating, and Feature. 
         */

        public long ItemNumber { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public double Wattage { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public bool IsAvailible
        {
            get
            {
                bool IsAvailible = Quantity > 0;
                return IsAvailible;
            }
        }




        public Appliance(string brand, string color, double price, double wattage, int itemnumber, int quantity)
        {
            Brand = brand;
            Color = color;
            Price = price;
            Wattage = wattage;
            ItemNumber = itemnumber;
            Quantity = quantity;
        }

        // Method
        public override string ToString()
        {
            return $"Item Number: {ItemNumber}\nBrand: {Brand}\nQuantity: {Quantity}\nWattage: {Wattage}\nColor: {Color}\nPrice: {Price:C}";
        }

        public void PrintApplianceList(List<Appliance> ListApp)
        {
            foreach (Appliance appliance in ListApp)
            {
                Console.WriteLine($"Brand: {appliance.Brand}");
                Console.WriteLine($"Color: {appliance.Color}");
                Console.WriteLine($"Price: {appliance.Price}");
                Console.WriteLine($"Wattage: {appliance.Wattage}");
                Console.WriteLine($"ItemNumber: {appliance.ItemNumber}");
                Console.WriteLine($"Quantity: {appliance.Quantity}");
            }
        }

        /// <summary>
        /// Types of appliances
        /// </summary>
        public enum ApplianceTypes
        {
            Unknown,
            Refrigerator = 1,
            Vacuum = 2,
            Microwave = 3,
            Dishwasher = 4
        }
        public ApplianceTypes Type
        {
            get
            {
                return DetermineApplianceTypeFromItemNumber(_itemNumber);
            }
        }
        private readonly int _itemNumber;
        private readonly string _brand;
        private int _quantity;
        private readonly double _wattage;
        private readonly string _color;
        private readonly double _price;

        public static ApplianceTypes DetermineApplianceTypeFromItemNumber(long itemNumber)
        {
            string firstDigitStr = itemNumber.ToString().Substring(0, 1);
            short firstDigit = short.Parse(firstDigitStr);

            if (firstDigit == 1)
            {
                // Refrigerator
                return ApplianceTypes.Refrigerator;
            }
            else if (firstDigit == 2)
            {
                // Vacuum
                return ApplianceTypes.Vacuum;
            }
            else if (firstDigit == 3)
            {
                // Microwave
                return ApplianceTypes.Microwave;
            }
            else if (firstDigit == 4 || firstDigit == 5)
            {
                // Dishwasher
                return ApplianceTypes.Dishwasher;
            }
            else
            {
                // Unknown
                return ApplianceTypes.Unknown;
            }
        }
    }
}
