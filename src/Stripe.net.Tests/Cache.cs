using System;
using System.ComponentModel;

namespace Stripe.Tests
{
    public static class Cache
    {
        
        public static StripeAccountCreateOptions ManagedAccountWithCardOptions { get; set; }

        private static StripeAccount _managedAccount { get; set; }

        public static StripeAccount GetManagedAccountWithCard()
        {
            if(_managedAccount != null) return _managedAccount;

            var options = test_data.stripe_account_create_options.ValidAccountWithCard();
            options.Country = "US";
            options.Email = $"joe{ Guid.NewGuid() }@blahblah.com";
            options.Managed = true;
            options.TosAcceptanceDate = DateTime.UtcNow.Date;
            options.TosAcceptanceIp = "8.8.8.8";
            options.TosAcceptanceUserAgent = "user-agent-7";

            ManagedAccountWithCardOptions = options;

            return _managedAccount = new StripeAccountService().Create(options);
        }

 

    }
}
