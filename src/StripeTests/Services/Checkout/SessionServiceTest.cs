namespace StripeTests.Checkout
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.Checkout;
    using Xunit;

    public class SessionServiceTest : BaseStripeTest
    {
        private const string SessionId = "cs_123";
        private readonly SessionService service;
        private readonly SessionCreateOptions createOptions;
        private readonly SessionListOptions listOptions;
        private readonly SessionListLineItemsOptions listLineItemsOptions;

        public SessionServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new SessionService(this.StripeClient);

            this.createOptions = new SessionCreateOptions
            {
                CancelUrl = "https://stripe.com/cancel",
                ClientReferenceId = "1234",
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        Images = new List<string>
                        {
                            "https://stripe.com/image1",
                        },
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            Currency = "usd",
                            Product = "prod_123",
                            UnitAmountDecimal = 0.01234567890m, // Ensure decimals work
                        },
                        Name = "item name",
                        Quantity = 2,
                    },
                    new SessionLineItemOptions
                    {
                        Images = new List<string>
                        {
                            "https://stripe.com/image1",
                        },
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            Currency = "usd",
                            Product = "prod_ABC",
                            Recurring = new SessionLineItemPriceDataRecurringOptions
                            {
                                Interval = "day",
                                IntervalCount = 15,
                            },
                            UnitAmountDecimal = 0.01234567890m, // Ensure decimals work
                        },
                        Quantity = 2,
                    },
                },
                PaymentIntentData = new SessionPaymentIntentDataOptions
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
                    },
                },
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },
                SuccessUrl = "https://stripe.com/success",
            };

            this.listOptions = new SessionListOptions
            {
                Limit = 1,
            };

            this.listLineItemsOptions = new SessionListLineItemsOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var session = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout/sessions");
            Assert.NotNull(session);
            Assert.Equal("checkout.session", session.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var session = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout/sessions");
            Assert.NotNull(session);
            Assert.Equal("checkout.session", session.Object);
        }

        [Fact]
        public void Get()
        {
            var session = this.service.Get(SessionId);
            this.AssertRequest(HttpMethod.Get, "/v1/checkout/sessions/cs_123");
            Assert.NotNull(session);
            Assert.Equal("checkout.session", session.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var session = await this.service.GetAsync(SessionId);
            this.AssertRequest(HttpMethod.Get, "/v1/checkout/sessions/cs_123");
            Assert.NotNull(session);
            Assert.Equal("checkout.session", session.Object);
        }

        [Fact]
        public void List()
        {
            var intents = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/checkout/sessions");
            Assert.NotNull(intents);
            Assert.Equal("list", intents.Object);
            Assert.Single(intents.Data);
            Assert.Equal("checkout.session", intents.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var intents = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/checkout/sessions");
            Assert.NotNull(intents);
            Assert.Equal("list", intents.Object);
            Assert.Single(intents.Data);
            Assert.Equal("checkout.session", intents.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var intent = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(intent);
            Assert.Equal("checkout.session", intent.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var intent = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(intent);
            Assert.Equal("checkout.session", intent.Object);
        }

        [Fact]
        public void ListLineItems()
        {
            var lineItems = this.service.ListLineItems(SessionId, this.listLineItemsOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/checkout/sessions/cs_123/line_items");
            Assert.NotNull(lineItems);
            Assert.Equal("list", lineItems.Object);
            Assert.Single(lineItems.Data);
            Assert.Equal("item", lineItems.Data[0].Object);
        }

        [Fact]
        public async Task ListLineItemsAsync()
        {
            var lineItems = await this.service.ListLineItemsAsync(SessionId, this.listLineItemsOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/checkout/sessions/cs_123/line_items");
            Assert.NotNull(lineItems);
            Assert.Equal("list", lineItems.Object);
            Assert.Single(lineItems.Data);
            Assert.Equal("item", lineItems.Data[0].Object);
        }

        [Fact]
        public void ListLineItemsAutoPaging()
        {
            var lineItem = this.service.ListLineItemsAutoPaging(SessionId, this.listLineItemsOptions).First();
            Assert.NotNull(lineItem);
            Assert.Equal("item", lineItem.Object);
        }

        [Fact]
        public async Task ListLineItemsAutoPagingAsync()
        {
            var lineItem = await this.service.ListLineItemsAutoPagingAsync(SessionId, this.listLineItemsOptions).FirstAsync();
            Assert.NotNull(lineItem);
            Assert.Equal("item", lineItem.Object);
        }
    }
}
