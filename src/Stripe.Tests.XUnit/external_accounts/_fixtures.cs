using System;
using System.Collections.Generic;
using System.Reflection;

namespace Stripe.Tests.Xunit
{
    public class external_account_fixture : IDisposable
    {
        public StripeExternalAccountCreateOptions ExernalAccountCreateOptionsBankAccount { get; }
        public StripeExternalAccountUpdateOptions ExernalAccountBankAccountUpdateOptions { get; }
        public StripeExternalAccountUpdateOptions ExernalAccountCardUpdateOptions { get; }

        public StripeAccount Account { get; }
        public StripeExternalAccount ExternalAccountCard { get; }
        public StripeExternalAccount ExternalAccountBankAccount { get; }
        public StripeExternalAccount ExternalAccountBankAccountUpdated { get; }
        public StripeExternalAccount ExternalAccountCardUpdated { get; }
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

            ExernalAccountBankAccountUpdateOptions = new StripeExternalAccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" }
                }
            };

            ExernalAccountCardUpdateOptions = new StripeExternalAccountUpdateOptions
            {
                ExternalAccountCard = new StripeExternalAccountCardUpdateOptions
                {
                    ExpirationMonth = 01,
                    ExpirationYear = 2028,
                    Name = "Updated Name"
                }
            };

            var service = new StripeExternalAccountService(Cache.ApiKey);

            ExternalAccountCard = service.Create(Account.Id, new StripeExternalAccountCreateOptions
            {
                ExternalAccountTokenId = "tok_visa_debit"
            });
            ExternalAccountBankAccount = service.Create(Account.Id, ExernalAccountCreateOptionsBankAccount);
            ExternalAccountBankAccountUpdated = service.Update(Account.Id, ExternalAccountBankAccount.Id, ExernalAccountBankAccountUpdateOptions);
            ExternalAccountCardUpdated = service.Update(Account.Id, ExternalAccountCard.Id, ExernalAccountCardUpdateOptions);
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
