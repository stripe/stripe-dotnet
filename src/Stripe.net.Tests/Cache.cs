using System;
using System.ComponentModel;

namespace Stripe.Tests
{
    public static class Cache
    {
        public static StripeAccountCreateOptions CustomAccountWithCardOptions { get; set; }
        public static StripeAccountCreateOptions CustomAccountWithBankAccountOptions { get; set; }

        private static StripeAccount _customAccountWithCard { get; set; }
        private static StripeAccount _customAccountWithBankAccount { get; set; }

        public static StripeAccount GetCustomAccountWithCard()
        {  
            if(_customAccountWithCard != null) return _customAccountWithCard;

            var options = test_data.stripe_account_create_options.ValidAccountWithCard();
            options.Country = "US";
            options.Email = $"joe{ Guid.NewGuid() }@blahblah.com";
            options.Type = StripeAccountType.Custom;
            options.TosAcceptanceDate = DateTime.UtcNow.Date;
            options.TosAcceptanceIp = "8.8.8.8";
            options.TosAcceptanceUserAgent = "user-agent-7";

            CustomAccountWithCardOptions = options;

            return _customAccountWithCard = new StripeAccountService().Create(options);
        }

        public static StripeAccount GetCustomAccountWithBankAccount()
        {
            if (_customAccountWithBankAccount != null) return _customAccountWithBankAccount;

            var options = test_data.stripe_account_create_options.ValidAccountWithBankAccount();
            options.Country = "US";
            options.Email = $"joe{ Guid.NewGuid() }@blahblah.com";
            options.Type = StripeAccountType.Custom;

            CustomAccountWithBankAccountOptions = options;

            return _customAccountWithBankAccount = new StripeAccountService().Create(options);
        }

    }
}
