namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class ApplePayDomainServiceTest : BaseStripeTest
    {
        private const string DomainId = "apwc_123";

        private ApplePayDomainService service;
        private ApplePayDomainCreateOptions createOptions;
        private ApplePayDomainListOptions listOptions;

        public ApplePayDomainServiceTest()
        {
            this.service = new ApplePayDomainService();

            this.createOptions = new ApplePayDomainCreateOptions()
            {
                DomainName = "example.com"
            };

            this.listOptions = new ApplePayDomainListOptions()
            {
                Limit = 2,
            };
        }

        [Fact]
        public void Create()
        {
            var domain = this.service.Create(this.createOptions);
            Assert.NotNull(domain);
            Assert.Equal("apple_pay_domain", domain.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var domain = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(domain);
            Assert.Equal("apple_pay_domain", domain.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(DomainId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(DomainId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var domain = this.service.Get(DomainId);
            Assert.NotNull(domain);
            Assert.Equal("apple_pay_domain", domain.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var domain = await this.service.GetAsync(DomainId);
            Assert.NotNull(domain);
            Assert.Equal("apple_pay_domain", domain.Object);
        }

        [Fact]
        public void List()
        {
            var domains = this.service.List(this.listOptions);
            Assert.NotNull(domains);
            Assert.Equal("list", domains.Object);
            Assert.Single(domains.Data);
            Assert.Equal("apple_pay_domain", domains.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var domains = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(domains);
            Assert.Equal("list", domains.Object);
            Assert.Single(domains.Data);
            Assert.Equal("apple_pay_domain", domains.Data[0].Object);
        }
    }
}
