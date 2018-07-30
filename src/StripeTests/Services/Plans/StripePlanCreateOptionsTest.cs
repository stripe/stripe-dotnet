namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class StripePlanCreateOptionsTest : BaseStripeTest
    {
        private StripePlanService service;

        public StripePlanCreateOptionsTest()
        {
            this.service = new StripePlanService();
        }

        [Fact]
        public void SerializeTiersProperly()
        {
            var options = new StripePlanCreateOptions
            {
                Tiers = new List<StripePlanTierOptions>
                {
                    new StripePlanTierOptions
                    {
                        Amount = 1000,
                        UpTo = new StripePlanTierOptions.UpToBound
                        {
                            Bound = 10
                        }
                    },
                    new StripePlanTierOptions
                    {
                        Amount = 2000,
                        UpTo = new StripePlanTierOptions.UpToInf()
                    }
                },
            };

            var url = this.service.ApplyAllParameters(options, string.Empty, false);
            Assert.Equal("?tiers[0][amount]=1000&tiers[0][up_to]=10&tiers[1][amount]=2000&tiers[1][up_to]=inf", url);
        }
    }
}
