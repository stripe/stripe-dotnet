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
        public void list_is_not_null()
        {
            fixture.AccountList.Should().NotBeNull();
        }

        [Fact]
        public void list_has_atleast_one_item()
        {
            fixture.AccountList.ToList().Count.Should().BeGreaterOrEqualTo(1);
        }
    }
}

