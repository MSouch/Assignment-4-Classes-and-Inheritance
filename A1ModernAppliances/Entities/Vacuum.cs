using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Entities
{
    /// <summary>
    /// Represents a Vacuum
    /// </summary>
    internal class Vacuum : Appliance
    {
        /* Vacuums have an Item Number, Brand, Quantity, Wattage, Color, Price, Grade and Battery Voltage.  */

        public string Grade { get; set; }
        public double Voltage { get; set; }

        public Vacuum(long itemnumber, string brand, int quantity, double wattage, string color, double price, string grade, double voltage) : base(brand, color, price, wattage, itemnumber, quantity)
        {
            // Constructor
            Grade = grade;
            Voltage = voltage;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString() + $"\nGrade: {Grade}\nVoltage: {Voltage}V";
        }
    
    }
}
