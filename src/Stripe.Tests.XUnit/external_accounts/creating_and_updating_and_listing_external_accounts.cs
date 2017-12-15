using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_external_accounts : IClassFixture<external_account_fixture>
    {
        private readonly external_account_fixture fixture;

        public creating_and_updating_external_accounts(external_account_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_card_has_right_info()
        {
            fixture.ExternalAccountCard.Type.Should().Be(ExternalAccountType.Card);
        }

        [Fact]
        public void created_bank_account_has_right_info()
        {
            fixture.ExternalAccountBankAccount.Type.Should().Be(ExternalAccountType.BankAccount);
            fixture.ExternalAccountBankAccount.BankAccount.AccountId.Should().Be(fixture.Account.Id);
            fixture.ExternalAccountBankAccount.BankAccount.RoutingNumber.Should().Be(fixture.ExernalAccountCreateOptionsBankAccount.ExternalAccountBankAccount.RoutingNumber);
        }

        [Fact]
        public void updated_bank_account_has_right_metadata()
        {
            fixture.ExternalAccountBankAccountUpdated.BankAccount.Metadata["key"].Should().Be(fixture.ExernalAccountBankAccountUpdateOptions.Metadata["key"]);
        }

        [Fact]
        public void updated_card_has_right_info()
        {
            fixture.ExternalAccountCardUpdated.Card.ExpirationMonth.Should().Be(fixture.ExernalAccountCardUpdateOptions.ExternalAccountCard.ExpirationMonth);
            fixture.ExternalAccountCardUpdated.Card.ExpirationYear.Should().Be(fixture.ExernalAccountCardUpdateOptions.ExternalAccountCard.ExpirationYear);
            fixture.ExternalAccountCardUpdated.Card.Name.Should().Be(fixture.ExernalAccountCardUpdateOptions.ExternalAccountCard.Name);
        }

        [Fact]
        public void retrieved_has_right_info()
        {
            fixture.ExternalAccountRetrieved.Type.Should().Be(ExternalAccountType.Card);
            fixture.ExternalAccountRetrieved.Id.Should().Be(fixture.ExternalAccountCard.Id);
            fixture.ExternalAccountRetrieved.Card.Id.Should().Be(fixture.ExternalAccountCard.Id);
        }

        [Fact]
        public void deleted_has_the_right_details()
        {
            fixture.ExternalAccountDeleted.Id.Should().Be(fixture.ExternalAccountBankAccount.Id);
            fixture.ExternalAccountDeleted.Deleted.Should().Be(true);
        }

        [Fact]
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeExternalAccount> enumerable = fixture.ExternalAccountList as IEnumerable<StripeExternalAccount>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
            Assert.Equal(fixture.ExternalAccountList.ToList().Count, count);

        }

        [Fact]
        public void list_contents_equal()
        {

            var datahash = new HashSet<String>();
            foreach (var obj in fixture.ExternalAccountList.Data)
            {
                datahash.Add(obj.Id);
            }

            var enumhash = new HashSet<String>();
            IEnumerable<StripeExternalAccount> enumerable = fixture.ExternalAccountList as IEnumerable<StripeExternalAccount>;
            foreach (var obj in enumerable)
            {
                enumhash.Add(obj.Id);
            }

            Assert.Equal(datahash, enumhash);

        }

        [Fact]
        public void list_contains_extra_attributes()
        {
            Assert.NotNull(fixture.ExternalAccountList.Object);
            Assert.Equal(fixture.ExternalAccountList.Object, "list");
            Assert.NotNull(fixture.ExternalAccountList.Data);
            Assert.NotNull(fixture.ExternalAccountList.Url);
            Assert.Equal(fixture.ExternalAccountList.HasMore, false);
        }
    }
}


