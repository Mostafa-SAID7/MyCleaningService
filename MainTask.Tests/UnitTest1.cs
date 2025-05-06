namespace MainTask
{
    public class CarpetCleaningCalculator
    {
        public int PriceSmallRoom { get; set; } = 25;
        public int PriceLargeRoom { get; set; } = 35;
        public int TaxRate { get; set; } = 6;

        public double CalculateCost(int smallRooms, int largeRooms)
        {
            return (smallRooms * PriceSmallRoom) + (largeRooms * PriceLargeRoom);
        }

        public double CalculateTax(double cost)
        {
            return cost * TaxRate / 100;
        }

        public double CalculateTotal(double cost, double tax)
        {
            return cost + tax;
        }
    }
}