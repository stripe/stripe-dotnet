using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public class stripe_recipient_update_options
    {
        public static StripeRecipientUpdateOptions Valid()
        {
            var stripeRecipientUpdateOptions = new StripeRecipientUpdateOptions()
            {
                Name = "Billy Madison",
                TaxId = "000000000",
                Email = "billy@madison.com",
                Description = "Conditioner is better, it makes the hair silky and smooth",
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" },
                    { "C", "Value-C" }
                }
            };

            return stripeRecipientUpdateOptions;
        }
    }
}