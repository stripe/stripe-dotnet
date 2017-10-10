using System.Collections.Generic;
using System;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_retrieving_and_listing_apple_pay_domains : IClassFixture<apple_pay_domains_fixture>
    {
        private readonly apple_pay_domains_fixture fixture;

        public creating_retrieving_and_listing_apple_pay_domains(apple_pay_domains_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_has_domain_name()
        {
            fixture.Domain.DomainName.Should().Be(fixture.DomainCreateOptions.DomainName);
        }

        [Fact]
        public void retrieved_has_correct_id()
        {
            fixture.DomainRetrieved.Id.Should().Be(fixture.Domain.Id);
        }

        [Fact]
        public void list_is_iterable()
        {

            var count = 0;
            IEnumerable<StripeApplePayDomain> enumerable = fixture.Domains as IEnumerable<StripeApplePayDomain>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
            Assert.Equal(fixture.Domains.ToList().Count, count);
        }

        [Fact]
        public void list_contents_equal()
        {

            var datahash = new HashSet<String>();
            foreach (var obj in fixture.Domains.Data)
            {
                datahash.Add(obj.Id);
            }

            var enumhash = new HashSet<String>();
            IEnumerable<StripeApplePayDomain> enumerable = fixture.Domains as IEnumerable<StripeApplePayDomain>;
            foreach (var obj in enumerable)
            {
                enumhash.Add(obj.Id);
            }

            Assert.Equal(datahash, enumhash);
        }

        [Fact]
        public void list_contains_extra_attributes()
        {
            Assert.NotNull(fixture.Domains.Object);
            Assert.Equal(fixture.Domains.Object, "list");
            Assert.NotNull(fixture.Domains.Data);
            Assert.NotNull(fixture.Domains.Url);
            Assert.Equal(fixture.Domains.HasMore, false);
        }
    }
}
