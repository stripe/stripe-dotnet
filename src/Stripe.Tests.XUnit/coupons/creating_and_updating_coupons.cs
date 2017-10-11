using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_coupons : IClassFixture<coupons_fixture>
    {
        private readonly coupons_fixture fixture;

        public creating_and_updating_coupons(coupons_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_has_the_right_details()
        {
            fixture.Coupon.Id.Should().Be(fixture.CouponCreateOptions.Id);
            fixture.Coupon.PercentOff.Should().Be(fixture.CouponCreateOptions.PercentOff);
            fixture.Coupon.Duration.Should().Be(fixture.CouponCreateOptions.Duration);
            fixture.Coupon.DurationInMonths.Should().Be(fixture.CouponCreateOptions.DurationInMonths);
        }

        [Fact]
        public void updated_has_the_right_details()
        {
            fixture.CouponUpdated.Id.Should().Be(fixture.Coupon.Id);
            fixture.CouponUpdated.Metadata.Keys.Should().BeEquivalentTo(fixture.CouponUpdateOptions.Metadata.Keys);
        }

        [Fact]
        public void retrieved_has_the_right_id()
        {
            fixture.CouponRetrieved.Id.Should().Be(fixture.Coupon.Id);
        }

        [Fact]
        public void deleted_has_the_right_details()
        {
            fixture.CouponDeleted.Id.Should().Be(fixture.Coupon.Id);
            fixture.CouponDeleted.Deleted.Should().Be(true);
        }
    }
}
