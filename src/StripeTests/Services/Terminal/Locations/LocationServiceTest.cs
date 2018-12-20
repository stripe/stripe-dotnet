namespace StripeTests.Terminal
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.Terminal;
    using Xunit;

    public class LocationServiceTest : BaseStripeTest
    {
        private const string LocationId = "loc_123";

        private readonly LocationService service;
        private readonly LocationCreateOptions createOptions;
        private readonly LocationListOptions listOptions;
        private readonly LocationUpdateOptions updateOptions;

        public LocationServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new LocationService();

            this.createOptions = new LocationCreateOptions
            {
                Address = new AddressOptions
                {
                    State = "CA",
                    City = "City",
                    Line1 = "Line1",
                    Line2 = "Line2",
                    PostalCode = "90210",
                    Country = "US",
                },
                DisplayName = "my location",
            };

            this.listOptions = new LocationListOptions
            {
            };

            this.updateOptions = new LocationUpdateOptions
            {
                DisplayName = "my_location_update",
            };
        }

        [Fact]
        public void Create()
        {
            var location = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/locations");
            Assert.NotNull(location);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var location = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/locations");
            Assert.NotNull(location);
        }

        [Fact]
        public void Get()
        {
            var location = this.service.Get(LocationId);
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/locations/loc_123");
            Assert.NotNull(location);
        }

        [Fact]
        public async Task GetAsync()
        {
            var location = await this.service.GetAsync(LocationId);
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/locations/loc_123");
            Assert.NotNull(location);
        }

        [Fact]
        public void List()
        {
            var locations = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/locations");
            Assert.NotNull(locations);
        }

        [Fact]
        public async Task ListAsync()
        {
            var locations = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/locations");
            Assert.NotNull(locations);
        }

        [Fact]
        public void Update()
        {
            var location = this.service.Update(LocationId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/locations/loc_123");
            Assert.NotNull(location);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var location = await this.service.UpdateAsync(LocationId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/locations/loc_123");
            Assert.NotNull(location);
        }
    }
}
