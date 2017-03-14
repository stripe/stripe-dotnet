using System;
using System.ComponentModel;

namespace Stripe.Tests
{
    public static class Cache
    {
        public static StripeAccountCreateOptions ManagedAccountWithCardOptions { get; set; }
        public static StripeAccountCreateOptions ManagedAccountWithBankAccountOptions { get; set; }

        private static StripeAccount _managedAccountWithCard { get; set; }
        private static StripeAccount _managedAccountWithBankAccount { get; set; }

        public static StripeAccount GetManagedAccountWithCard()
        {  
            if(_managedAccountWithCard != null) return _managedAccountWithCard;

            var options = test_data.stripe_account_create_options.ValidAccountWithCard();
            options.Country = "US";
            options.Email = $"joe{ Guid.NewGuid() }@blahblah.com";
            options.Managed = true;
            options.TosAcceptanceDate = DateTime.UtcNow.Date;
            options.TosAcceptanceIp = "8.8.8.8";
            options.TosAcceptanceUserAgent = "user-agent-7";

            ManagedAccountWithCardOptions = options;

            return _managedAccountWithCard = new StripeAccountService().Create(options);
        }

        public static StripeAccount GetManagedAccountWithBankAccount()
        {
            if (_managedAccountWithBankAccount != null) return _managedAccountWithBankAccount;

            var options = test_data.stripe_account_create_options.ValidAccountWithBankAccount();
            options.Country = "US";
            options.Email = $"joe{ Guid.NewGuid() }@blahblah.com";
            options.Managed = true;

            ManagedAccountWithBankAccountOptions = options;

            return _managedAccountWithBankAccount = new StripeAccountService().Create(options);
        }

    }
}
