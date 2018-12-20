namespace StripeTests
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class CheckoutSessionServiceTest : BaseStripeTest
    {
        private readonly CheckoutSessionService service;
        private readonly CheckoutSessionCreateOptions createOptions;

        public CheckoutSessionServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new CheckoutSessionService();

            this.createOptions = new CheckoutSessionCreateOptions
            {
                AllowedSourceTypes = new List<string>
                {
                    "card",
                },
                CancelUrl = "https://stripe.con/cancel",
                ClientReferenceId = "1234",
                LineItems = new List<CheckoutSessionLineItemOptions>
                {
                    new CheckoutSessionLineItemOptions
                    {
                        Amount = 1234,
                        Currency = "usd",
                        Description = "item1",
                        Images = new List<string>
                        {
                            "https://stripe.com/image1",
                        },
                        Name = "item name",
                        Quantity = 2,
                    },
                },
                PaymentIntentData = new CheckoutSessionPaymentIntentDataOptions
                {
                    Description = "description",
                    Shipping = new ChargeShippingOptions
                    {
                        Name = "name",
                        Phone = "555-555-5555",
                        Address = new AddressOptions
                        {
                            State = "CA",
                            City = "City",
                            Line1 = "Line1",
                            Line2 = "Line2",
                            PostalCode = "90210",
                            Country = "US",
                        },
                    }
                },
                SuccessUrl = "https://stripe.con/success",
            };
        }

        [Fact]
        public void Create()
        {
            var session = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout_sessions");
            Assert.NotNull(session);
            Assert.Equal("checkout_session", session.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var session = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout_sessions");
            Assert.NotNull(session);
            Assert.Equal("checkout_session", session.Object);
        }
    }
}
