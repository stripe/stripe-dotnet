using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class coupon_test
    {
        private string previousApiBase;
        private readonly string resourceId = "co_123";
        private StripeCouponService service;

        public coupon_test()
        {
            this.service = new StripeCouponService(Cache.ApiKey);
            this.previousApiBase = StripeConfiguration.GetApiBase();
            StripeConfiguration.SetApiBase("http://localhost:12111/v1");
        }

        ~coupon_test()
        {
            StripeConfiguration.SetApiBase(this.previousApiBase);
        }

        [Fact]
        public void create_succeeds()
        {
            var options = new StripeCouponCreateOptions() {
                // Add a space at the end to ensure the ID is properly URL encoded
                // when passed in the URL for other methods
                Id = "co_123 ",
                PercentOff = 25,
                Duration = "repeating",
                DurationInMonths = 3,
            };

            var coupon = service.Create(options);

            Assert.NotNull(coupon);
            coupon.Id.Should().Be(options.Id);
            coupon.PercentOff.Should().Be(options.PercentOff);
            coupon.Duration.Should().Be(options.Duration);
            coupon.DurationInMonths.Should().Be(options.DurationInMonths);
        }

        [Fact]
        public void update_succeeds()
        {
            var options = new StripeCouponUpdateOptions {
              Metadata = new Dictionary<string, string>{{"key_1", "value_1"}}
            };

            var coupon = service.Update(resourceId, options);

            Assert.NotNull(coupon);
            coupon.Id.Should().Be(resourceId);
            // stripe-mock does not update metadata so we can't verify this part
        }

        [Fact]
        public void get_succeeds()
        {
            var coupon = service.Get(resourceId);

            Assert.NotNull(coupon);
            coupon.Id.Should().Be(resourceId);
        }

        [Fact]
        public void delete_succeeds()
        {
            var coupon = service.Delete(resourceId);

            Assert.NotNull(coupon);
            coupon.Deleted.Should().BeTrue();
        }

        [Fact]
        public void list_succeeds()
        {
            var coupons = service.List();

            Assert.NotNull(coupons);

            var count = 0;
            IEnumerable<StripeCoupon> enumerable = coupons as IEnumerable<StripeCoupon>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
            Assert.Equal(coupons.ToList().Count > 0, true);
            Assert.Equal(coupons.ToList().Count, count);

            var datahash = new HashSet<string>();
            foreach (var obj in coupons.Data)
            {
                datahash.Add(obj.Id);
            }

            var enumhash = new HashSet<string>();
            IEnumerable<StripeCoupon> enumerable2 = coupons as IEnumerable<StripeCoupon>;
            foreach (var obj in enumerable2)
            {
                enumhash.Add(obj.Id);
            }

            Assert.Equal(datahash, enumhash);

            Assert.NotNull(coupons.Object);
            Assert.Equal(coupons.Object, "list");
            Assert.NotNull(coupons.Data);
            Assert.NotNull(coupons.Url);
        }
    }
}
