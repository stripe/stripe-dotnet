using System;

namespace Stripe.Tests.test_data
{
	public static class stripe_customer_update_subscription_options
	{
		public static StripeCustomerUpdateSubscriptionOptions ValidCard(string _planId = null, string _couponId = null, DateTime? _trialEnd = null)
		{
			var stripeCustomerUpdateSubscriptionOptions = new StripeCustomerUpdateSubscriptionOptions()
			{
				CardAddressCountry = "US",
				CardAddressLine1 = "A1A Beachfront Avenue",
				CardAddressState = "FL",
				CardAddressZip = "33101",
				CardCvc = "1661",
				CardExpirationMonth = "10",
				CardExpirationYear = "2012",
				CardName = "Vanilla Ice",
				CardNumber = "4242424242424242",
			};

			if (_planId != null)
				stripeCustomerUpdateSubscriptionOptions.PlanId = _planId;

			if (_couponId != null)
				stripeCustomerUpdateSubscriptionOptions.CouponId = _couponId;

			if (_trialEnd != null)
				stripeCustomerUpdateSubscriptionOptions.TrialEnd = _trialEnd;

			return stripeCustomerUpdateSubscriptionOptions;
		}
	}
}
