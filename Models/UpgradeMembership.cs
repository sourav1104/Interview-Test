using System;

namespace Interview_Test
{
    public class UpgradeMembership : IProduct, IUpgradeMembership, INotifyUser
    {
        public void ApplyUpgradeMembership()
        {
            Console.WriteLine("Upgrade Membership : Applied Upgrade Membership");
        }

        public void SendEmail()
        {
            Console.WriteLine("Upgrade Membership : Sent Email to the user");
        }

        public void StartProductShipment()
        {
            ApplyUpgradeMembership();
            SendEmail();
        }
    }
}