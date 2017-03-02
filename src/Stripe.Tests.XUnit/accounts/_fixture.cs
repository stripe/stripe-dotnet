using System;
using System.Collections.Generic;
using System.Reflection;

namespace Stripe.Tests.Xunit
{
    public class account_fixture : IDisposable
    {
        public StripeAccountCreateOptions AccountCreateOptions { get; }
        public StripeAccountUpdateOptions AccountUpdateOptions { get; }

        public StripeAccount Account { get; }
        public StripeAccount AccountUpdated { get; }
        public StripeAccount AccountRetrieved { get; }
        public IEnumerable<StripeAccount> AccountList { get; }

        public account_fixture()
        {
            // create a file to attach to the additional owner as a verification document
            var fileService = new StripeFileUploadService(Cache.ApiKey);
            var fileStream = GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.Tests.Xunit._resources.bumble.jpg");
            var file = fileService.Create("bumble.jpg", fileStream, StripeFilePurpose.IdentityDocument);

            AccountCreateOptions = new StripeAccountCreateOptions
            {
                BusinessName = "Subtracts",
                BusinessPrimaryColor = "#" + new Random().Next(0, 6).ToString("D6"),
                BusinessUrl = "http://subtracts.io",
                DebitNegativeBalances = true,
                DeclineChargeOnAvsFailure = false,
                DeclineChargeOnCvcFailure = true,
                DefaultCurrency = "usd",
                Email = "caesar@turing.dpn",
                Managed = true,
                ExternalCardAccount = new StripeAccountCardOptions()
                {
                    AddressCountry = "US",
                    AddressLine1 = "24 Main St",
                    AddressLine2 = "Apt 24",
                    AddressCity = "Raleigh",
                    AddressState = "NC",
                    AddressZip = "27617",
                    Cvc = "1223",
                    ExpirationMonth = "10",
                    ExpirationYear = "2021",
                    Name = "Julius Turing",
                    Number = "4000056655665556",
                    Currency = "usd",
                    DefaultForCurrency = true
                },
                LegalEntity = new StripeAccountLegalEntityOptions
                {
                    AdditionalOwners = new List<StripeAccountAdditionalOwner>
                    {
                        new StripeAccountAdditionalOwner
                        {
                            FirstName = "Bumble", LastName = "B",
                            BirthDay = 29, BirthMonth = 8, BirthYear = 2013,
                            VerificationDocument = file.Id
                        },
                        new StripeAccountAdditionalOwner
                        {
                            FirstName = "Trouble", LastName = "China",
                            State = "CA", CityOrTown = "RockAndWheat",
                            Line1 ="B", Line2 = "C", PostalCode = "27635",
                            Country = "US"
                        }
                    }
                }
            };

            AccountUpdateOptions = new StripeAccountUpdateOptions
            {
                BusinessUrl = "https://subtracts.io"
            };

            var service = new StripeAccountService(Cache.ApiKey);
            Account = service.Create(AccountCreateOptions);
            AccountUpdated = service.Update(Account.Id, AccountUpdateOptions);
            AccountRetrieved = service.Get(Account.Id);
            AccountList = service.List();
        }

        public void Dispose()
        {
            new StripeAccountService(Cache.ApiKey).Delete(Account.Id);
        }
    }
}
