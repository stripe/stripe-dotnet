namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeChargeServiceTest : BaseStripeTest
    {
        private const string ChargeId = "ch_123";

        private StripeChargeService service;
        private StripeChargeCaptureOptions captureOptions;
        private StripeChargeCreateOptions createOptions;
        private StripeChargeUpdateOptions updateOptions;
        private StripeChargeListOptions listOptions;

        public StripeChargeServiceTest()
        {
            this.service = new StripeChargeService();

            this.captureOptions = new StripeChargeCaptureOptions()
            {
                Amount = 123,
            };

            this.createOptions = new StripeChargeCreateOptions()
            {
                Amount = 123,
                Currency = "usd",
                SourceTokenOrExistingSourceId = "tok_123",
            };

            this.updateOptions = new StripeChargeUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new StripeChargeListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Capture()
        {
            var charge = this.service.Capture(ChargeId, this.captureOptions);
            Assert.NotNull(charge);
            Assert.Equal("charge", charge.Object);
        }

        [Fact]
        public async Task CaptureAsync()
        {
            var charge = await this.service.CaptureAsync(ChargeId, this.captureOptions);
            Assert.NotNull(charge);
            Assert.Equal("charge", charge.Object);
        }

        [Fact]
        public void Create()
        {
            var charge = this.service.Create(this.createOptions);
            Assert.NotNull(charge);
            Assert.Equal("charge", charge.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var charge = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(charge);
            Assert.Equal("charge", charge.Object);
        }

        [Fact]
        public void Get()
        {
            var charge = this.service.Get(ChargeId);
            Assert.NotNull(charge);
            Assert.Equal("charge", charge.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var charge = await this.service.GetAsync(ChargeId);
            Assert.NotNull(charge);
            Assert.Equal("charge", charge.Object);
        }

        [Fact]
        public void List()
        {
            var charges = this.service.List(this.listOptions);
            Assert.NotNull(charges);
            Assert.Equal("list", charges.Object);
            Assert.Single(charges.Data);
            Assert.Equal("charge", charges.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var charges = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(charges);
            Assert.Equal("list", charges.Object);
            Assert.Single(charges.Data);
            Assert.Equal("charge", charges.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var charge = this.service.Update(ChargeId, this.updateOptions);
            Assert.NotNull(charge);
            Assert.Equal("charge", charge.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var charge = await this.service.UpdateAsync(ChargeId, this.updateOptions);
            Assert.NotNull(charge);
            Assert.Equal("charge", charge.Object);
        }
    }
}
