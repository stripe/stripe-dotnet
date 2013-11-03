namespace Stripe
{
    public interface IStripeDisputeService
    {
        StripeDispute Update(string chargeId, string evidence = null);
    }
}