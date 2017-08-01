using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_accounts : IClassFixture<account_fixture>
    {
        private readonly account_fixture fixture;

        public creating_and_updating_accounts(account_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_has_legal_entity()
        {
            fixture.Account.LegalEntity.Should().NotBeNull();
        }

        [Fact]
        public void created_has_addditional_owners()
        {
            fixture.Account.LegalEntity.AdditionalOwners.Should().NotBeNull();
        }

        [Fact]
        public void created_has_the_right_number_of_additional_owners()
        {
            fixture.Account.LegalEntity.AdditionalOwners.Count.ShouldBeEquivalentTo(fixture.Account.LegalEntity.AdditionalOwners.Count);
        }

        [Fact]
        public void created_has_the_verification_document()
        {
            fixture.Account.LegalEntity.AdditionalOwners.First().LegalEntityVerification.DocumentId.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void updated_is_not_null()
        {
            fixture.AccountRetrieved.Should().NotBeNull();
        }

        [Fact]
        public void updated_has_right_business_url()
        {
            fixture.AccountRetrieved.BusinessUrl.Should().Be(fixture.AccountUpdateOptions.BusinessUrl);
        }

        [Fact]
        public void rejected_is_disabled()
        {
            fixture.AccountRejected.ChargesEnabled.Should().BeFalse();
            fixture.AccountRejected.PayoutsEnabled.Should().BeFalse();
            fixture.AccountRejected.AccountVerification.DisabledReason.Should().Be("rejected.terms_of_service");
        }

        [Fact]
        public void list_is_not_null()
        {
            fixture.AccountList.Should().NotBeNull();
        }

        [Fact]
        public void list_has_atleast_one_item()
        {
            fixture.AccountList.ToList().Count.Should().BeGreaterOrEqualTo(1);
        }

        [Fact]
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeAccount> enumerable = fixture.AccountList as IEnumerable<StripeAccount>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
            Assert.Equal(fixture.AccountList.ToList().Count, count);

        }

        [Fact]
        public void list_contents_equal()
        {

            var datahash = new HashSet<String>();
            foreach (var obj in fixture.AccountList.Data)
            {
                datahash.Add(obj.Id);
            }

            var enumhash = new HashSet<String>();
            IEnumerable<StripeAccount> enumerable = fixture.AccountList as IEnumerable<StripeAccount>;
            foreach (var obj in enumerable)
            {
                enumhash.Add(obj.Id);
            }

            Assert.Equal(datahash, enumhash);

        }

        [Fact]
        public void list_contains_extra_attributes()
        {
            Assert.NotNull(fixture.AccountList.Object);
            Assert.Equal(fixture.AccountList.Object, "list");
            Assert.NotNull(fixture.AccountList.Data);
            Assert.NotNull(fixture.AccountList.Url);
        } 
    }
}

