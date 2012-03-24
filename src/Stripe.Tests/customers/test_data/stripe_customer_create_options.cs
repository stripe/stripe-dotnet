using System;

namespace Stripe.Tests.test_data
{
	public static class stripe_customer_create_options
	{
		public static StripeCustomerCreateOptions ValidCard(string _planId = null, string _couponId = null, DateTime? _trialEnd = null)
		{
			var stripeCustomerCreateOptions = new StripeCustomerCreateOptions()
			{
				CardAddressCountry = "US",
				CardAddressLine1 = "234 Bacon St",
				CardAddressLine2 = "Apt 1",
				CardAddressState = "NC",
				CardAddressZip = "27617",
				Email = "pork@email.com",
				CardCvc = "1661",
				CardExpirationMonth = "10",
				CardExpirationYear = "2012",
				CardName = "Johnny Tenderloin",
				CardNumber = "4242424242424242",
				Description = "Johnny Tenderloin (pork@email.com)",
			};

			if (_planId != null)
				stripeCustomerCreateOptions.PlanId = _planId;

			if (_couponId != null)
				stripeCustomerCreateOptions.CouponId = _couponId;

			if (_trialEnd != null)
				stripeCustomerCreateOptions.TrialEnd = _trialEnd;

			return stripeCustomerCreateOptions;
		}

		public static StripeCustomerCreateOptions ValidToken(string tokenId, string _planId = null, string _couponId = null, DateTime? _trialEnd = null)
		{
			var stripeCustomerCreateOptions = new StripeCustomerCreateOptions()
			{
				TokenId = tokenId
			};

			if (_planId != null)
				stripeCustomerCreateOptions.PlanId = _planId;

			if (_couponId != null)
				stripeCustomerCreateOptions.CouponId = _couponId;

			if (_trialEnd != null)
				stripeCustomerCreateOptions.TrialEnd = _trialEnd;

			return stripeCustomerCreateOptions;
		}
	}
}
