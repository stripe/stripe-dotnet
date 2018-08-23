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
                        UnitAmount = 1000,
                        UpTo = new StripePlanTierOptions.UpToBound
                        {
                            Bound = 10
                        }
                    },
                    new StripePlanTierOptions
                    {
                        UnitAmount = 2000,
                        UpTo = new StripePlanTierOptions.UpToInf()
                    }
                },
            };

            var url = this.service.ApplyAllParameters(options, string.Empty, false);
            Assert.Equal("?tiers[0][unit_amount]=1000&tiers[0][up_to]=10&tiers[1][unit_amount]=2000&tiers[1][up_to]=inf", url);
        }
    }
}
