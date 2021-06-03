using System;

namespace Interview_Test
{
    public class PhysicalProduct : IProduct, IShipment, ICommission
    {
        public void GeneratePackingSlip()
        {
            Console.WriteLine("My Physical Product : Generated Packaging Slip");
        }

        public void PayCommissionToAgent()
        {
            Console.WriteLine("My Physical Product : Paid Commission to Agent");
        }

        public void StartProductShipment()
        {
            GeneratePackingSlip();
            PayCommissionToAgent();
        }
    }
}