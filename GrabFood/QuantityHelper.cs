using System.Windows.Forms;

namespace GrabFood
{
    public static class QuantityHelper
    {
        public static void Increase(ref int qty, Label label)
        {
            qty++;
            label.Text = qty.ToString();
        }

        public static void Decrease(ref int qty, Label label)
        {
            if (qty > 1)
            {
                qty--;
                label.Text = qty.ToString();
            }
        }
    }
}