namespace GrabFood
{
    public class OrderItem : Product
    {
        private int quantity;
        private double total;
        private string status;
        private string customerName;
        private string riderName;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string RiderName
        {
            get { return riderName; }
            set { riderName = value; }
        }
    }
}