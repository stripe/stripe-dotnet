using System;

namespace Stripe.Tests
{
    public static class Cache
    {
        // this will return null if you haven't asked for a managed account
        public static StripeAccountCreateOptions ManagedAccountOptions { get; set; }

        private static StripeAccount _managedAccount { get; set; }

        public static StripeAccount GetManagedAccount()
        {
            if(_managedAccount != null) return _managedAccount;

            var options = test_data.stripe_account_create_options.ValidAccountWithCard();
            options.Country = "US";
            options.Email = $"joe{ Guid.NewGuid() }@blahblah.com";
            options.Managed = true;
            options.TosAcceptanceDate = DateTime.UtcNow.Date;
            options.TosAcceptanceIp = "8.8.8.8";
            options.TosAcceptanceUserAgent = "user-agent-7";

            ManagedAccountOptions = options;

            return _managedAccount = new StripeAccountService().Create(options);
        }
    }
}
