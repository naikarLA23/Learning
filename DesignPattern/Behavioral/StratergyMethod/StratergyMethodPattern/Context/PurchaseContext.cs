using StratergyMethodPattern.Stratergy;

namespace StratergyMethodPattern.Context
{
    internal class PurchaseContext
    {
        private IPaymentStratergy _PaymentStratergy;
        internal void SetStratergy(IPaymentStratergy paymentStratergy)
        {
            _PaymentStratergy = paymentStratergy;
        }

        internal void PayBill(int amount)
        {
            _PaymentStratergy.MakePayment(amount);
        }
    }
}
