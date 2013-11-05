using Machine.Specifications;
using System.Linq;
namespace Stripe.Tests
{
	[Behaviors]
	public class balance_behaviors
	{
		protected static StripeBalance StripeBalance;

        It should_have_available_amounts = () =>
            StripeBalance.Available.Length.ShouldBeGreaterThan(0);
        It should_have_currency_for_available_balance = () =>
            StripeBalance.Available.First().Currency.ShouldNotBeNull();

	}
}