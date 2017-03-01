using System;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        private static StripeAccount ManagedAccount { get; set; }

        /// <summary>
        /// Gets the options used to create the <see cref="ManagedAccount" />. This will be null if <see cref="GetManagedAccount" /> has not been invoked.
        /// </summary>
        public static StripeAccountCreateOptions ManagedAccountCreateOptions { get; private set; }

        /// <summary>
        /// Gets a managed account. If one is not available, it will be created.
        /// </summary>
        public static StripeAccount GetManagedAccount()
        {
            if (ManagedAccount != null) return ManagedAccount;

            ManagedAccountCreateOptions = new StripeAccountCreateOptions
            {
                BusinessName = "Subtracts",
                BusinessPrimaryColor = "#" + new Random().Next(0, 6).ToString("D6"),
                BusinessUrl = "http://subtracts.io",
                DebitNegativeBalances = true,
                DeclineChargeOnAvsFailure = false,
                DeclineChargeOnCvcFailure = true,
                DefaultCurrency = "usd",
                Email = $"caesar@turing.dpn",
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
                }
            };

            return ManagedAccount = new StripeAccountService(ApiKey).Create(ManagedAccountCreateOptions);
        }
    }
}
