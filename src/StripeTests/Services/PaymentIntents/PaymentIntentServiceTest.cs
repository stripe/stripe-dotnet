namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class PaymentIntentServiceTest : BaseStripeTest
    {
        private const string PaymentIntentId = "pi_123";

        private PaymentIntentService service;
        private PaymentIntentCancelOptions cancelOptions;
        private PaymentIntentCaptureOptions captureOptions;
        private PaymentIntentConfirmOptions confirmOptions;
        private PaymentIntentCreateOptions createOptions;
        private PaymentIntentListOptions listOptions;
        private PaymentIntentUpdateOptions updateOptions;

        public PaymentIntentServiceTest()
        {
            this.service = new PaymentIntentService();

            this.cancelOptions = new PaymentIntentCancelOptions
            {
            };

            this.captureOptions = new PaymentIntentCaptureOptions
            {
                AmountToCapture = 123,
            };

            this.confirmOptions = new PaymentIntentConfirmOptions
            {
                SaveSourceToCustomer = true,
            };

            this.createOptions = new PaymentIntentCreateOptions
            {
                AllowedSourceTypes = new List<string>
                {
                    "card",
                },
                Amount = 1000,
                Currency = "usd",
                TransferData = new PaymentIntentTransferDataOptions
                {
                    Amount = 100,
                    Destination = "acct_123",
                }
            };

            this.listOptions = new PaymentIntentListOptions
            {
                Limit = 1,
            };

            this.updateOptions = new PaymentIntentUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };
        }

        [Fact]
        public void Cancel()
        {
            var intent = this.service.Cancel(PaymentIntentId, this.cancelOptions);
            Assert.NotNull(intent);
            Assert.Equal("payment_intent", intent.Object);
        }

        [Fact]
        public async Task CancelAsync()
        {
            var intent = await this.service.CancelAsync(PaymentIntentId, this.cancelOptions);
            Assert.NotNull(intent);
            Assert.Equal("payment_intent", intent.Object);
        }

        [Fact]
        public void Capture()
        {
            var intent = this.service.Capture(PaymentIntentId, this.captureOptions);
            Assert.NotNull(intent);
            Assert.Equal("payment_intent", intent.Object);
        }

        [Fact]
        public async Task CaptureAsync()
        {
            var intent = await this.service.CaptureAsync(PaymentIntentId, this.captureOptions);
            Assert.NotNull(intent);
            Assert.Equal("payment_intent", intent.Object);
        }

        [Fact]
        public void Confirm()
        {
            var intent = this.service.Confirm(PaymentIntentId, this.confirmOptions);
            Assert.NotNull(intent);
            Assert.Equal("payment_intent", intent.Object);
        }

        [Fact]
        public async Task ConfirmAsync()
        {
            var intent = await this.service.ConfirmAsync(PaymentIntentId, this.confirmOptions);
            Assert.NotNull(intent);
            Assert.Equal("payment_intent", intent.Object);
        }

        [Fact]
        public void Create()
        {
            var intent = this.service.Create(this.createOptions);
            Assert.NotNull(intent);
            Assert.Equal("payment_intent", intent.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var intent = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(intent);
            Assert.Equal("payment_intent", intent.Object);
        }

        [Fact]
        public void Get()
        {
            var intent = this.service.Get(PaymentIntentId);
            Assert.NotNull(intent);
            Assert.Equal("payment_intent", intent.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var intent = await this.service.GetAsync(PaymentIntentId);
            Assert.NotNull(intent);
            Assert.Equal("payment_intent", intent.Object);
        }

        [Fact]
        public void List()
        {
            var intents = this.service.List(this.listOptions);
            Assert.NotNull(intents);
            Assert.Equal("list", intents.Object);
            Assert.Single(intents.Data);
            Assert.Equal("payment_intent", intents.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var intents = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(intents);
            Assert.Equal("list", intents.Object);
            Assert.Single(intents.Data);
            Assert.Equal("payment_intent", intents.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var intent = this.service.Update(PaymentIntentId, this.updateOptions);
            Assert.NotNull(intent);
            Assert.Equal("payment_intent", intent.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var intent = await this.service.UpdateAsync(PaymentIntentId, this.updateOptions);
            Assert.NotNull(intent);
            Assert.Equal("payment_intent", intent.Object);
        }
    }
}
