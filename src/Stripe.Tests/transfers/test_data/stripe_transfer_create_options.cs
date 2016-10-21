using System;
using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public class stripe_transfer_create_options
    {
        public static StripeTransferCreateOptions Valid(string recipient = "self")
        {
            var stripeTransferCreateOptions = new StripeTransferCreateOptions()
            {
                Amount = 50,
                Currency = "usd",
                Recipient = recipient,
                Description = "test-transfer-description-" + Guid.NewGuid(),
                StatementDescriptor = "test-transfer-statement-descriptor" + Guid.NewGuid(),
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                }
            };

            return stripeTransferCreateOptions;
        }

        public static StripeTransferCreateOptions ValidForDestination(string destination)
        {
            var stripeTransferCreateOptions = new StripeTransferCreateOptions()
            {
                Amount = 50,
                Currency = "usd",
                Destination = destination,
                Description = "test-transfer-description-" + Guid.NewGuid(),
                StatementDescriptor = "test-transfer-statement-descriptor" + Guid.NewGuid(),
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                }
            };

            return stripeTransferCreateOptions;
        }
    }
}
