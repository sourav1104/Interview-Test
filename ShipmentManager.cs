using System;

namespace Interview_Test
{
    public class ShipmentManager
    {
        private IProduct _product;

        public ShipmentManager(IProduct product)
        {
            _product = product;
        }

        public void StartShipment()
        {
            _product.StartProductShipment();
        }
    }
}