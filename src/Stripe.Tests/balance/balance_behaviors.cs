using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class balance_behaviors
    {
        protected static StripeBalance StripeBalance;

        It should_have_pending_amounts = () =>
            StripeBalance.Pending.Count.ShouldBeGreaterThan(0);

        It should_have_available_amounts = () =>
            StripeBalance.Available.Count.ShouldBeGreaterThan(0);
        
        It should_specify_amount_on_available_amount = () =>
            StripeBalance.Available.First().Amount.ShouldNotBeNull();

        It should_specify_currency_on_available_amount = () =>
            StripeBalance.Available.First().Currency.ShouldNotBeNull();
    }
}
