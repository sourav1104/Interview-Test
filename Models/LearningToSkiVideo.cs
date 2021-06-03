using System;

namespace Interview_Test
{
    public class LearningToSkiVideo : IProduct, IAddFreeBees
    {
        public void AddFreeBees()
        {
            Console.WriteLine("Learning To Ski Video : Added First Aid Video to the packaging slip");
        }

        public void StartProductShipment()
        {
            AddFreeBees();
        }
    }
}