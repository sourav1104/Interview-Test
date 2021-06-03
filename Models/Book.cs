using System;

namespace Interview_Test
{
    public class Book : IProduct, IShipment, ICommission, IBook
    {
        public void GeneratePackingSlip()
        {
            Console.WriteLine("My Book : Generated Packaging Slip");
        }

        public void PayCommissionToAgent()
        {
            Console.WriteLine("My Book : Paid Commission to Agent");
        }

        public void GenerateDuplicatePackingSlip()
        {
            Console.WriteLine("My Book : Generated Duplicate Packaging Slip");
        }

        public void StartProductShipment()
        {
            GeneratePackingSlip();
            PayCommissionToAgent();
            GenerateDuplicatePackingSlip();
        }
    }
}