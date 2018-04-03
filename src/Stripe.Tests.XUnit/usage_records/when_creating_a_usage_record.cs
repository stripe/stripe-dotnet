using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;
using Stripe.Infrastructure;

namespace Stripe.Tests.Xunit
{
    public class creating_a_usage_record : IClassFixture<usage_record_fixture>
    {
        private readonly usage_record_fixture fixture;

        public creating_a_usage_record(usage_record_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void has_the_correct_quantity()
        {
            fixture.UsageRecord.Quantity.Should().Be(fixture.UsageRecordCreateOptions.Quantity);
        }

        [Fact]
        public void has_the_correct_timestamp()
        {
            fixture.UsageRecord.Timestamp.ConvertDateTimeToEpoch().Should().Be(
                fixture.UsageRecordCreateOptions.Timestamp.ConvertDateTimeToEpoch());
        }
    }
}
