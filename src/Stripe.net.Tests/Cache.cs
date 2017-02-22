using System;

namespace Stripe.Tests
{
    public static class Cache
    {
        private static StripeAccount _managedAccount { get; set; }

        public static StripeAccount GetManagedAccount()
        {
            if(_managedAccount != null) return _managedAccount;

            var accountOptions = test_data.stripe_account_create_options.ValidAccountWithBankAccount();
            accountOptions.Managed = true;

            return _managedAccount = new StripeAccountService().Create(accountOptions);
        }
    }
}
