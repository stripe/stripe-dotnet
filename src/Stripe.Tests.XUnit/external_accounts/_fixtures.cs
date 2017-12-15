using System;
using System.Collections.Generic;
using System.Reflection;

namespace Stripe.Tests.Xunit
{
    public class external_account_fixture : IDisposable
    {
        public StripeExternalAccountCreateOptions ExernalAccountCreateOptionsBankAccount { get; }
        public StripeExternalAccountUpdateOptions ExernalAccountUpdateOptions { get; }

        public StripeAccount Account { get; }
        public StripeExternalAccount ExternalAccountCard { get; }
        public StripeExternalAccount ExternalAccountBankAccount { get; }
        public StripeExternalAccount ExternalAccountUpdated { get; }
        public StripeExternalAccount ExternalAccountRetrieved { get; }
        public StripeList<StripeExternalAccount> ExternalAccountList { get; }
        public StripeDeleted ExternalAccountDeleted { get; }

        public external_account_fixture()
        {
            Account = new StripeAccountService(Cache.ApiKey).Create(new StripeAccountCreateOptions
            {
                Country = "US",
                Type = StripeAccountType.Custom
            });

            ExernalAccountCreateOptionsBankAccount = new StripeExternalAccountCreateOptions
            {
                ExternalAccountBankAccount = new StripeAccountBankAccountOptions
                {
                    AccountNumber = "000123456789",
                    Country = "US",
                    Currency = "usd",
                    RoutingNumber = "110000000"
                }
            };

            ExernalAccountUpdateOptions = new StripeExternalAccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" }
                }
            };

            var service = new StripeExternalAccountService(Cache.ApiKey);

            ExternalAccountCard = service.Create(Account.Id, new StripeExternalAccountCreateOptions
            {
                ExternalAccountTokenId = "tok_visa_debit"
            });
            ExternalAccountBankAccount = service.Create(Account.Id, ExernalAccountCreateOptionsBankAccount);
            ExternalAccountUpdated = service.Update(Account.Id, ExternalAccountCard.Id, ExernalAccountUpdateOptions);
            ExternalAccountRetrieved = service.Get(Account.Id, ExternalAccountCard.Id);
            ExternalAccountList = service.List(Account.Id);
            ExternalAccountDeleted = service.Delete(Account.Id, ExternalAccountBankAccount.Id);
        }

        public void Dispose()
        {
            new StripeAccountService(Cache.ApiKey).Delete(Account.Id);
        }
    }
}
