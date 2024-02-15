using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Entities
{
    /// <summary>
    /// Represents a dishwasher
    /// </summary>
    internal class Dishwasher : Appliance
    {
        /* Dishwashers have an Item Number, Brand, Quantity, Wattage, Color, Price, Sound Rating, and Feature.   */

        public string SoundRatings { get; set; }
        public string Feature { get; set; }

        public Dishwasher(int itemnumber, string brand, int quantity, double wattage, string color, double price, string feature, string soundrating) : base(brand, color, price, wattage, itemnumber, quantity)
        {
            // Constructor
            SoundRatings = soundrating;
            Feature = feature;
        }

        //Methods
        public override string ToString()
        {
            if (SoundRatings is "Qt")
            {
                SoundRatings = "Quietest";
            }
            else if (SoundRatings is "Qr")
            {
                SoundRatings = "Quieter";
            }
            else if (SoundRatings is "Qu")
            {
                SoundRatings = "Quiet";
            }
            else if (SoundRatings is "M")
            {
                SoundRatings = "Moderate";
            }
            return base.ToString() + $"\nSound Rating: {SoundRatings}\nFeature: {Feature} ";
        }
    }
}
