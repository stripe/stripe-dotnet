using System.Collections.Generic;
namespace Stripe.Tests.test_data
{
	public static class stripe_charge_create_options
	{
		public static StripeChargeCreateOptions ValidCard()
		{
			return new StripeChargeCreateOptions()
			{
				CardAddressCountry = "US",
				CardAddressLine1 = "24 Beef Flank St",
				CardAddressLine2 = "Apt 24",
				CardAddressCity = "BIGGIE",
				CardAddressState = "NC",
				CardAddressZip = "27617",
				CardCvc = "1223",
				CardExpirationMonth = "10",
				CardExpirationYear = "2021",
				CardName = "Joe Meatballs",
				CardNumber = "4242424242424242",
				Description = "Joe Meatball Charge",
				AmountInCents = 5153,
				Currency = "usd",
				Metadata = new Dictionary<string, string>
				{
					{ "A", "Value-A" },
					{ "B", "Value-B" }
				}
			};
		}

		public static StripeChargeCreateOptions InvalidCard()
		{
			return new StripeChargeCreateOptions()
			{
				CardAddressCountry = "US",
				CardAddressLine1 = "24 Poopie St",
				CardAddressCity = "Yeehaw Beebop ChickyChicky",
				CardAddressState = "NC",
				CardAddressZip = "90210",
				CardCvc = "1223",
				CardExpirationMonth = "10",
				CardExpirationYear = "2004",
				CardName = "Joe Meatballs",
				CardNumber = "425221",
				Description = "Joe Meatball Charge",
				AmountInCents = 5153,
				Currency = "usd"
			};
		}

		public static StripeChargeCreateOptions ValidCustomer(string customerId)
		{
			return new StripeChargeCreateOptions()
			{
				Description = "Buddy Roast (beef@email.com)",
				AmountInCents = 2994,
				Currency = "usd",
				CustomerId = customerId
			};
		}

		public static StripeChargeCreateOptions ValidToken(string _tokenId)
		{
			return new StripeChargeCreateOptions()
			{
				AmountInCents = 2001,
				Currency = "usd",
				TokenId = _tokenId
			};
		}

        public static StripeChargeCreateOptions ValidCardFromPCICompliantService()
        {
            var baseCard = ValidCard();
            baseCard.Ip = "127.0.0.1";
            baseCard.UserAgent =
                "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36";
            baseCard.Referrer = "http://test-referrer.wowee.com";
            baseCard.ExternalId = "cid-9986";
            baseCard.PaymentUserAgent = "Stripe.Net";
            return baseCard;
        }
	}
}