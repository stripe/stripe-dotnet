namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class TaxIdServiceTest : BaseStripeTest
    {
        private const string CustomerId = "cus_123";
        private const string TaxIdId = "txi_123";

        private readonly TaxIdService service;
        private readonly TaxIdCreateOptions createOptions;
        private readonly TaxIdListOptions listOptions;

        public TaxIdServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new TaxIdService(this.StripeClient);

            this.createOptions = new TaxIdCreateOptions
            {
                Type = "eu_vat",
                Value = "11111",
            };

            this.listOptions = new TaxIdListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var person = this.service.Create(CustomerId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/tax_ids");
            Assert.NotNull(person);
            Assert.Equal("tax_id", person.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var person = await this.service.CreateAsync(CustomerId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/tax_ids");
            Assert.NotNull(person);
            Assert.Equal("tax_id", person.Object);
        }

        [Fact]
        public void Delete()
        {
            var person = this.service.Delete(CustomerId, TaxIdId);
            this.AssertRequest(HttpMethod.Delete, "/v1/customers/cus_123/tax_ids/txi_123");
            Assert.NotNull(person);
            Assert.Equal("tax_id", person.Object);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var person = await this.service.DeleteAsync(CustomerId, TaxIdId);
            this.AssertRequest(HttpMethod.Delete, "/v1/customers/cus_123/tax_ids/txi_123");
            Assert.NotNull(person);
            Assert.Equal("tax_id", person.Object);
        }

        [Fact]
        public void Get()
        {
            var person = this.service.Get(CustomerId, TaxIdId);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/tax_ids/txi_123");
            Assert.NotNull(person);
            Assert.Equal("tax_id", person.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var person = await this.service.GetAsync(CustomerId, TaxIdId);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/tax_ids/txi_123");
            Assert.NotNull(person);
            Assert.Equal("tax_id", person.Object);
        }

        [Fact]
        public void List()
        {
            var persons = this.service.List(CustomerId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/tax_ids");
            Assert.NotNull(persons);
            Assert.Equal("list", persons.Object);
            Assert.Single(persons.Data);
            Assert.Equal("tax_id", persons.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var persons = await this.service.ListAsync(CustomerId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/tax_ids");
            Assert.NotNull(persons);
            Assert.Equal("list", persons.Object);
            Assert.Single(persons.Data);
            Assert.Equal("tax_id", persons.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var person = this.service.ListAutoPaging(CustomerId, this.listOptions).First();
            Assert.NotNull(person);
            Assert.Equal("tax_id", person.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var person = await this.service.ListAutoPagingAsync(CustomerId, this.listOptions).FirstAsync();
            Assert.NotNull(person);
            Assert.Equal("tax_id", person.Object);
        }
    }
}
