namespace StripeTests
{
    using System.Collections.Generic;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class PriceCreateOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeTiersProperly()
        {
            var options = new PriceCreateOptions
            {
                Tiers = new List<PriceTierOptions>
                {
                    new PriceTierOptions
                    {
                        UnitAmount = 1000,
                        UpTo = 10,
                    },
                    new PriceTierOptions
                    {
                        UnitAmount = 2000,
                        UpTo = PriceTierUpTo.Inf,
                    },
                },
            };

            Assert.Equal(
                "tiers[0][unit_amount]=1000&tiers[0][up_to]=10&" +
                "tiers[1][unit_amount]=2000&tiers[1][up_to]=inf",
                FormEncoder.CreateQueryString(options));
        }

        [Fact]
        public void SerializeDecimalTiersProperly()
        {
            var options = new PriceCreateOptions
            {
                Tiers = new List<PriceTierOptions>
                {
                    new PriceTierOptions
                    {
                        UnitAmountDecimal = 0.003m,
                        FlatAmountDecimal = 0.12m,
                        UpTo = 10,
                    },
                    new PriceTierOptions
                    {
                        UnitAmountDecimal = 0.004m,
                        FlatAmountDecimal = 0.24m,
                        UpTo = PriceTierUpTo.Inf,
                    },
                },
            };

            Assert.Equal(
                "tiers[0][flat_amount_decimal]=0.12&tiers[0][unit_amount_decimal]=0.003&tiers[0][up_to]=10&" +
                "tiers[1][flat_amount_decimal]=0.24&tiers[1][unit_amount_decimal]=0.004&tiers[1][up_to]=inf",
                FormEncoder.CreateQueryString(options));
        }
    }
}
