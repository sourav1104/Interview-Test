using System;

namespace Interview_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ShipmentManager myShipmentManager = new ShipmentManager(new NewMembership());
            myShipmentManager.StartShipment();
        }
    }
}
