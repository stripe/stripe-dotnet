namespace StripeTests.Issuing
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe.Issuing;
    using Xunit;

    public class IssuingDisputeServiceTest : BaseStripeTest
    {
        private const string DisputeId = "idp_123";

        private DisputeService service;
        private DisputeCreateOptions createOptions;
        private DisputeUpdateOptions updateOptions;
        private DisputeListOptions listOptions;

        public IssuingDisputeServiceTest()
        {
            this.service = new DisputeService();

            this.createOptions = new DisputeCreateOptions()
            {
                Evidence = new EvidenceOptions
                {
                    FraudulentDisputeExplanation = "Explanation",
                    FraudulentUncategorizedFile = "file_123",
                },
                Reason = "fraudulent",
                TransactionId = "ipi_123",
            };

            this.updateOptions = new DisputeUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new DisputeListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var dispute = this.service.Create(this.createOptions);
            Assert.NotNull(dispute);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var dispute = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(dispute);
        }

        [Fact]
        public void Get()
        {
            var dispute = this.service.Get(DisputeId);
            Assert.NotNull(dispute);
        }

        [Fact]
        public async Task GetAsync()
        {
            var dispute = await this.service.GetAsync(DisputeId);
            Assert.NotNull(dispute);
        }

        [Fact]
        public void List()
        {
            var disputes = this.service.List(this.listOptions);
            Assert.NotNull(disputes);
        }

        [Fact]
        public async Task ListAsync()
        {
            var disputes = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(disputes);
        }

        [Fact]
        public void Update()
        {
            var dispute = this.service.Update(DisputeId, this.updateOptions);
            Assert.NotNull(dispute);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var dispute = await this.service.UpdateAsync(DisputeId, this.updateOptions);
            Assert.NotNull(dispute);
        }
    }
}
