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
        public StripeList<StripeAccount> AccountList { get; }
        public StripeAccount AccountRejected { get; }

        public account_fixture()
        {
            // create a file to attach to the additional owner as a verification document
            var fileService = new StripeFileUploadService(Cache.ApiKey);
            var fileStream = GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.Tests.XUnit._resources.bumble.jpg");
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
                Type = StripeAccountType.Custom,
                ExternalCardAccount = new StripeAccountCardOptions()
                {
                    TokenId = "tok_visa_debit"
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

            var _rejectOptions = new StripeAccountRejectOptions
            {
                Reason = "terms_of_service"
            };

            var service = new StripeAccountService(Cache.ApiKey);
            Account = service.Create(AccountCreateOptions);
            AccountUpdated = service.Update(Account.Id, AccountUpdateOptions);
            AccountRetrieved = service.Get(Account.Id);
            AccountList = service.List();
            AccountRejected = service.Reject(Account.Id, _rejectOptions);
        }

        public void Dispose()
        {
            new StripeAccountService(Cache.ApiKey).Delete(Account.Id);
        }
    }
}
