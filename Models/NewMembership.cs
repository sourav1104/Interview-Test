using System;

namespace Interview_Test
{
    public class NewMembership : IProduct, INewMembership, INotifyUser
    {
        public void GenearteNewMembership()
        {
            Console.WriteLine("New Membership : Generated New Membership");
        }

        public void SendEmail()
        {
            Console.WriteLine("New Membership : Sent Email to the user");
        }

        public void StartProductShipment()
        {
            GenearteNewMembership();
            SendEmail();
        }
    }
}