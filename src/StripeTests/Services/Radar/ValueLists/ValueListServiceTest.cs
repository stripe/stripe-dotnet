namespace StripeTests.Radar
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe.Radar;
    using Xunit;

    public class ValueListServiceTest : BaseStripeTest
    {
        private const string ValueListId = "rsl_123";

        private readonly ValueListService service;
        private readonly ValueListCreateOptions createOptions;
        private readonly ValueListUpdateOptions updateOptions;
        private readonly ValueListListOptions listOptions;

        public ValueListServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new ValueListService(this.StripeClient);

            this.createOptions = new ValueListCreateOptions
            {
                Alias = "alias",
                ItemType = "ip_address",
                Name = "name",
            };

            this.updateOptions = new ValueListUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new ValueListListOptions
            {
                Alias = "alias",
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var valueList = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_lists");
            Assert.NotNull(valueList);
            Assert.Equal("radar.value_list", valueList.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var valueList = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_lists");
            Assert.NotNull(valueList);
            Assert.Equal("radar.value_list", valueList.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(ValueListId);
            this.AssertRequest(HttpMethod.Delete, "/v1/radar/value_lists/rsl_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(ValueListId);
            this.AssertRequest(HttpMethod.Delete, "/v1/radar/value_lists/rsl_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var valueList = this.service.Get(ValueListId);
            this.AssertRequest(HttpMethod.Get, "/v1/radar/value_lists/rsl_123");
            Assert.NotNull(valueList);
            Assert.Equal("radar.value_list", valueList.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var valueList = await this.service.GetAsync(ValueListId);
            this.AssertRequest(HttpMethod.Get, "/v1/radar/value_lists/rsl_123");
            Assert.NotNull(valueList);
            Assert.Equal("radar.value_list", valueList.Object);
        }

        [Fact]
        public void List()
        {
            var valueLists = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/radar/value_lists");
            Assert.NotNull(valueLists);
            Assert.Equal("list", valueLists.Object);
            Assert.Single(valueLists.Data);
            Assert.Equal("radar.value_list", valueLists.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var valueLists = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/radar/value_lists");
            Assert.NotNull(valueLists);
            Assert.Equal("list", valueLists.Object);
            Assert.Single(valueLists.Data);
            Assert.Equal("radar.value_list", valueLists.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var valueList = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(valueList);
            Assert.Equal("radar.value_list", valueList.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var valueList = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(valueList);
            Assert.Equal("radar.value_list", valueList.Object);
        }

        [Fact]
        public void Update()
        {
            var valueList = this.service.Update(ValueListId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_lists/rsl_123");
            Assert.NotNull(valueList);
            Assert.Equal("radar.value_list", valueList.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var valueList = await this.service.UpdateAsync(ValueListId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_lists/rsl_123");
            Assert.NotNull(valueList);
            Assert.Equal("radar.value_list", valueList.Object);
        }
    }
}
