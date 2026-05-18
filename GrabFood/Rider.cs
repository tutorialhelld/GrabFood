namespace GrabFood
{
    public class Rider : User
    {
        private string phoneNumber;
        private string vehicleType;
        private string status;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}