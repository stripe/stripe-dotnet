using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_an_account_with_a_legal_entity
    {
        private static StripeAccount _stripeAccount;
        private static StripeAccountService _stripeAccountService;
        private static StripeAccountCreateOptions _stripeAccountCreateOptions;
        private static DateTime? _timestamp;

        Establish context = () =>
        {
            _stripeAccountService = new StripeAccountService();
            _stripeAccountCreateOptions = new StripeAccountCreateOptions()
            {
                Email = "joe@" + Guid.NewGuid() + ".com",
                Managed = true
            };

            _timestamp = DateTime.UtcNow.Date;
            _stripeAccountCreateOptions.LegalEntity = new StripeAccountLegalEntityOptions()
            {
                AddressCity = "Raleigh",
                AddressTwoLetterCountry = "US",
                AddressLine1 = "1234 Stripe St",
                AddressLine2 = "Apt 8a",
                AddressPostalCode = "27613",
                AddressState = "NC",
                BirthDay = "25",
                BirthMonth = "12",
                BirthYear = "1981",
                Gender = "female",
                FirstName = "Joe",
                LastName = "Schmoe",
                Type = "individual"
            };
        };

        Because of = () =>
            _stripeAccount = _stripeAccountService.Create(_stripeAccountCreateOptions);

        It should_have_the_correct_email_address = () =>
            _stripeAccount.Email.ShouldEqual(_stripeAccountCreateOptions.Email);

        It should_have_the_correct_legal_entity_values = () =>
        {
            _stripeAccount.LegalEntity.Address.City.ShouldEqual(_stripeAccountCreateOptions.LegalEntity.AddressCity);
            _stripeAccount.LegalEntity.Address.Country.ShouldEqual(_stripeAccountCreateOptions.LegalEntity.AddressTwoLetterCountry);
            _stripeAccount.LegalEntity.Address.Line1.ShouldEqual(_stripeAccountCreateOptions.LegalEntity.AddressLine1);
            _stripeAccount.LegalEntity.Address.Line2.ShouldEqual(_stripeAccountCreateOptions.LegalEntity.AddressLine2);
            _stripeAccount.LegalEntity.Address.PostalCode.ShouldEqual(_stripeAccountCreateOptions.LegalEntity.AddressPostalCode);
            _stripeAccount.LegalEntity.Address.State.ShouldEqual(_stripeAccountCreateOptions.LegalEntity.AddressState);
            _stripeAccount.LegalEntity.BirthDay.Day.Value.ToString().ShouldEqual(_stripeAccountCreateOptions.LegalEntity.BirthDay);
            _stripeAccount.LegalEntity.BirthDay.Month.Value.ToString().ShouldEqual(_stripeAccountCreateOptions.LegalEntity.BirthMonth);
            _stripeAccount.LegalEntity.BirthDay.Year.Value.ToString().ShouldEqual(_stripeAccountCreateOptions.LegalEntity.BirthYear);
            _stripeAccount.LegalEntity.FirstName.ShouldEqual(_stripeAccountCreateOptions.LegalEntity.FirstName);
            _stripeAccount.LegalEntity.Gender.ShouldEqual(_stripeAccountCreateOptions.LegalEntity.Gender);
            _stripeAccount.LegalEntity.LastName.ShouldEqual(_stripeAccountCreateOptions.LegalEntity.LastName);
            _stripeAccount.LegalEntity.Type.ShouldEqual(_stripeAccountCreateOptions.LegalEntity.Type);
        };
    }
}
