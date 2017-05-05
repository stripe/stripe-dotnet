using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_card_source
    {
        private StripeSource Source { get; set; }

        public creating_and_updating_card_source()
        {
            var options = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Card,
                Amount = 1,
                Currency = "usd",
                Token = Cache.GetToken().Id,
                RedirectReturnUrl = "http://no.where/webhooks"
            };

            Source = new StripeSourceService(Cache.ApiKey).Create(options);
        }

        [Fact]
        public void source_should_not_be_null()
        {
            Source.Should().NotBeNull();
        }

        // ***** example of the full response

        //{
        //    "id": "src_1AG8C1LWlyqCpbLpb4Vzk58R",
        //    "object": "source",
        //    "amount": 1,
        //    "client_secret": "src_client_secret_WvVqH07h6yiUuR2PP3XnDZdj",
        //    "created": 1493997485,
        //    "currency": "usd",
        //    "flow": "none",
        //    "livemode": false,
        //    "metadata": {},
        //    "owner": {
        //        "address": null,
        //        "email": null,
        //        "name": "Jason Isbell",
        //        "phone": null,
        //        "verified_address": null,
        //        "verified_email": null,
        //        "verified_name": null,
        //        "verified_phone": null
        //    },
        //    "status": "chargeable",
        //    "type": "card",
        //    "usage": "reusable",
        //    "card": {
        //        "exp_month": 10,
        //        "exp_year": 2025,
        //        "address_line1_check": "unchecked",
        //        "address_zip_check": "unchecked",
        //        "brand": "Visa",
        //        "country": "US",
        //        "cvc_check": "unchecked",
        //        "fingerprint": "s7wTOkEvTa7J0PFf",
        //        "funding": "credit",
        //        "last4": "4242",
        //        "three_d_secure": "optional",
        //        "tokenization_method": null,
        //        "dynamic_last4": null
        //    }
        //}
    }
}
