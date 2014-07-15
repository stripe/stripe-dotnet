using System.Collections.Generic;
using System.Configuration;
namespace Stripe.Tests.test_data
{
	public static class stripe_refund_create_options
	{
		public static StripeRefundCreateOptions FullRefundWithApplicationFee()
		{
			return new StripeRefundCreateOptions()
			{
                RefundApplicationFee = true,
				Metadata = new Dictionary<string, string>
				{
					{ "A", "Value-A" },
					{ "B", "Value-B" }
				}
			};
		}

        public static StripeRefundCreateOptions FullRefundWithoutApplicationFee()
        {
            return new StripeRefundCreateOptions()
            {
                RefundApplicationFee = false,
                Metadata = new Dictionary<string, string>
				{
					{ "A", "Value-A" },
					{ "B", "Value-B" }
				}
            };
        }

        public static StripeRefundCreateOptions PartialRefundWithApplicationFee()
		{
            return new StripeRefundCreateOptions()
			{
				Amount = 10,
                RefundApplicationFee = true
			};
		}

        public static StripeRefundCreateOptions PartialRefundWithoutApplicationFee()
		{
            return new StripeRefundCreateOptions()
			{
				Amount = 10,
                RefundApplicationFee = false
			};
		}
	}
}