namespace StripeTests.Radar
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe.Radar;
    using Xunit;

    public class ValueListItemServiceTest : BaseStripeTest
    {
        private const string ValueListItemId = "rsli_123";

        private readonly ValueListItemService service;
        private readonly ValueListItemCreateOptions createOptions;
        private readonly ValueListItemListOptions listOptions;

        public ValueListItemServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new ValueListItemService();

            this.createOptions = new ValueListItemCreateOptions
            {
                Value = "value",
                ValueListId = "rsl_123",
            };

            this.listOptions = new ValueListItemListOptions
            {
                Limit = 1,
                ValueListId = "rsl_123",
            };
        }

        [Fact]
        public void Create()
        {
            var valueListItem = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_list_items");
            Assert.NotNull(valueListItem);
            Assert.Equal("radar.value_list_item", valueListItem.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var valueListItem = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_list_items");
            Assert.NotNull(valueListItem);
            Assert.Equal("radar.value_list_item", valueListItem.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(ValueListItemId);
            this.AssertRequest(HttpMethod.Delete, "/v1/radar/value_list_items/rsli_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(ValueListItemId);
            this.AssertRequest(HttpMethod.Delete, "/v1/radar/value_list_items/rsli_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var valueListItem = this.service.Get(ValueListItemId);
            this.AssertRequest(HttpMethod.Get, "/v1/radar/value_list_items/rsli_123");
            Assert.NotNull(valueListItem);
            Assert.Equal("radar.value_list_item", valueListItem.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var valueListItem = await this.service.GetAsync(ValueListItemId);
            this.AssertRequest(HttpMethod.Get, "/v1/radar/value_list_items/rsli_123");
            Assert.NotNull(valueListItem);
            Assert.Equal("radar.value_list_item", valueListItem.Object);
        }

        [Fact]
        public void List()
        {
            var valueListItems = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/radar/value_list_items");
            Assert.NotNull(valueListItems);
            Assert.Equal("list", valueListItems.Object);
            Assert.Single(valueListItems.Data);
            Assert.Equal("radar.value_list_item", valueListItems.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var valueListItems = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/radar/value_list_items");
            Assert.NotNull(valueListItems);
            Assert.Equal("list", valueListItems.Object);
            Assert.Single(valueListItems.Data);
            Assert.Equal("radar.value_list_item", valueListItems.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var valueListItems = this.service.ListAutoPaging(this.listOptions).ToList();
            Assert.NotNull(valueListItems);
            Assert.Equal("radar.value_list_item", valueListItems[0].Object);
        }
    }
}
