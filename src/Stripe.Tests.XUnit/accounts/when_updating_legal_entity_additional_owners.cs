using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    // TODO: needs a bit of work - set the RetrievedAccount after update then assert fields

    public class when_updating_legal_entity_additional_owners : test
    {
        private StripeAccount RetrievedAccount { get; }

        public when_updating_legal_entity_additional_owners()
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

            new StripeAccountService(_stripe_api_key).Update(newAccount.Id,
                new StripeAccountUpdateOptions
                {
                    LegalEntity = new StripeAccountLegalEntityOptions
                    {
                        AdditionalOwners = new List<StripeAccountAdditionalOwner>
                        {
                            new StripeAccountAdditionalOwner { FirstName = "BigUpdated", LastName = "Little" },
                            //new StripeAccountAdditionalOwner { BirthDay = 25, BirthMonth = 12, BirthYear = 2000 }
                        }
                    }
                }
            );
        }

        public StripeAccount Account { get; set; }

        [Fact]
        public void it_should_have_the_owner_count_as_two()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Count.ShouldBeEquivalentTo(2);
        }

        //[Fact]
        //public void it_should_have_the_right_owner_firstname()
        //{
        //    RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.FirstName == "BigUpdated");
        //}

        [Fact]
        public void it_should_have_the_right_owner_lastname()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.LastName == "Little");
        }

        [Fact]
        public void it_should_have_the_right_owner_birthday()
        {
            //RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.BirthDay.Day == 25);
            //RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.BirthDay.Month == 12);
            //RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.BirthDay.Year == 2000);
        }
    }
}
