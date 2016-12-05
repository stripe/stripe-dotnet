using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.xUnit
{
    public class when_adding_legal_entity_additional_owners : test
    {
        private StripeAccount RetrievedAccount { get; }

        public when_adding_legal_entity_additional_owners()
        {
            var newAccount = new StripeAccountService(_stripe_api_key).Create(
                new StripeAccountCreateOptions
                {
                    Email = $"merry{ Guid.NewGuid() }@christmas.com",
                    Managed = true,
                    LegalEntity = new StripeAccountLegalEntityOptions
                    {
                        AdditionalOwners = new List<StripeAccountAdditionalOwner>
                        {
                            new StripeAccountAdditionalOwner { FirstName = "Big", LastName = "Little" },
                            new StripeAccountAdditionalOwner { FirstName = "Trouble", LastName = "China" }
                        }
                    }
                }
            );

            RetrievedAccount = new StripeAccountService(_stripe_api_key).Get(newAccount.Id);
        }

        public StripeAccount Account { get; set; }

        [Fact]
        public void it_should_have_the_legal_entity()
        {
            RetrievedAccount.LegalEntity.Should().NotBeNull();
        }

        [Fact]
        public void it_should_have_the_addditional_owners()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().NotBeNull();
        }

        [Fact]
        public void it_should_have_the_owner_count_as_two()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Count.ShouldBeEquivalentTo(2);
        }

        [Fact]
        public void it_should_have_the_owner_firstnames_right()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.FirstName == "Big");
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.FirstName == "Trouble");
        }

        [Fact]
        public void it_should_have_the_owner_lastnames_right()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.LastName == "Little");
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.LastName == "China");
        }
    }
}
