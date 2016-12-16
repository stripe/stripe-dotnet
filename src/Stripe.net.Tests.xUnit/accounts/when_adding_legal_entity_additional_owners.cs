using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.xUnit
{
    public class adding_additional_owners : test
    {
        private StripeAccount RetrievedAccount { get; }

        public adding_additional_owners()
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
                            new StripeAccountAdditionalOwner
                            {
                                FirstName = "Big", LastName = "Little",
                                BirthDay = 25, BirthMonth = 12, BirthYear = 2000
                            },
                            new StripeAccountAdditionalOwner
                            {
                                FirstName = "Trouble", LastName = "China",
                                State = "CA", CityOrTown = "A",
                                Line1 ="B", Line2 = "C", PostalCode = "27635",
                                Country = "US"
                            }
                        }
                    }
                }
            );

            RetrievedAccount = new StripeAccountService(_stripe_api_key).Get(newAccount.Id);
        }

        public StripeAccount Account { get; set; }

        [Fact]
        public void has_legal_entity()
        {
            RetrievedAccount.LegalEntity.Should().NotBeNull();
        }

        [Fact]
        public void has_addditional_owners()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().NotBeNull();
        }

        [Fact]
        public void right_state()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.Address.State == "CA");
        }

        [Fact]
        public void right_owners_count()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Count.ShouldBeEquivalentTo(2);
        }

        [Fact]
        public void right_city()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.Address.CityOrTown == "A");
        }

        [Fact]
        public void right_line_1()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.Address.Line1 == "B");
        }

        [Fact]
        public void right_line_2()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.Address.Line2 == "C");
        }

        [Fact]
        public void right_postal_code()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.Address.PostalCode == "27635");
        }

        [Fact]
        public void right_country()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners.Should().Contain(owner => owner.Address.Country == "US");
        }

        [Fact]
        public void right_first_name()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners[0].FirstName.ShouldBeEquivalentTo("Big");
        }

        [Fact]
        public void right_last_name()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners[0].LastName.ShouldBeEquivalentTo("Little");
        }

        [Fact]
        public void right_birthday()
        {
            RetrievedAccount.LegalEntity.AdditionalOwners[0].BirthDay.Day.ShouldBeEquivalentTo(25);
            RetrievedAccount.LegalEntity.AdditionalOwners[0].BirthDay.Month.ShouldBeEquivalentTo(12);
            RetrievedAccount.LegalEntity.AdditionalOwners[0].BirthDay.Year.ShouldBeEquivalentTo(2000);
        }
    }
}

