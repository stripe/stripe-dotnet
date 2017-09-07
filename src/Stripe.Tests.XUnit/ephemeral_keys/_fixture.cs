using System;

namespace Stripe.Tests.Xunit
{
    public class ephemeral_keys_fixture : IDisposable
    {
        public StripeEphemeralKeyCreateOptions EphemeralKeyCreateOptions { get; set; }

        public StripeEphemeralKey EphemeralKey { get; set; }

        public ephemeral_keys_fixture()
        {
            var customer = Cache.GetCustomer();

            var service = new StripeEphemeralKeyService(Cache.ApiKey);

            EphemeralKeyCreateOptions = new StripeEphemeralKeyCreateOptions
            {
                CustomerId = customer.Id,
            };

            var requestOptions = new StripeRequestOptions();
            requestOptions.EphemeralKeyStripeVersion = "2017-05-25";

            EphemeralKey = service.Create(EphemeralKeyCreateOptions, requestOptions);
        }

        public void Dispose() { }
    }
}
