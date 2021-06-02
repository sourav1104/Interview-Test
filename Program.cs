using System;

namespace Interview_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ShipmentManager myShipmentManager = new ShipmentManager(PaymentType.UpgradeMembership);
            myShipmentManager.StartShipment();
        }
    }

    public enum PaymentType
    {
        PhysicalProduct = 0,
        Book,
        NewMembership,
        UpgradeMembership,
        LearningToSkiVideo
    }

    public interface IProduct
    {
        public void StartProductShipment();
    }

    public interface IShipment
    {
        public void GeneratePackingSlip();
    }

    public interface ICommission
    {
        public void PayCommissionToAgent();
    }

    public interface IBook
    {
        public void GenerateDuplicatePackingSlip();
    }

    public interface INotifyUser
    {
        public void SendEmail();
    }

    public interface INewMembership
    {
        public void GenearteNewMembership();
    }

    public interface IUpgradeMembership
    {
        public void ApplyUpgradeMembership();
    }

    public interface IAddFreeBees
    {
        public void AddFreeBees();
    }

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

    public class ShipmentManager
    {
        private PaymentType paymentType;

        public ShipmentManager(PaymentType pType)
        {
            this.paymentType = pType;
        }

        public void StartShipment()
        {
            switch (paymentType)
            {
                case PaymentType.PhysicalProduct:
                    PhysicalProduct myPhysicalProduct = new PhysicalProduct();
                    myPhysicalProduct.StartProductShipment();
                    break;

                case PaymentType.Book:
                    Book myBooK = new Book();
                    myBooK.StartProductShipment();
                    break;

                case PaymentType.NewMembership:
                    NewMembership myNewMembership = new NewMembership();
                    myNewMembership.StartProductShipment();
                    break;

                case PaymentType.UpgradeMembership:
                    UpgradeMembership myUpgradeMembership = new UpgradeMembership();
                    myUpgradeMembership.StartProductShipment();
                    break;

                case PaymentType.LearningToSkiVideo:
                    LearningToSkiVideo myLearningToSkiVideo = new LearningToSkiVideo();
                    myLearningToSkiVideo.StartProductShipment();
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
