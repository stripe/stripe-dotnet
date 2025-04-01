// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class VaultService : Service
    {
        private V2.Core.Vault.GbBankAccountService gbBankAccounts;
        private V2.Core.Vault.UsBankAccountService usBankAccounts;

        internal VaultService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal VaultService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Core.Vault.GbBankAccountService GbBankAccounts => this.gbBankAccounts ??= new V2.Core.Vault.GbBankAccountService(
            this.Requestor);

        public virtual V2.Core.Vault.UsBankAccountService UsBankAccounts => this.usBankAccounts ??= new V2.Core.Vault.UsBankAccountService(
            this.Requestor);
    }
}
