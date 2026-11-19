// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class CoreService : Service
    {
        private V2.Core.AccountService accounts;
        private V2.Core.AccountLinkService accountLinks;
        private V2.Core.AccountTokenService accountTokens;
        private V2.Core.ClaimableSandboxService claimableSandboxes;
        private V2.Core.EventService events;
        private V2.Core.EventDestinationService eventDestinations;
        private V2.Core.VaultService vault;

        internal CoreService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CoreService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Core.AccountService Accounts => this.accounts ??= new V2.Core.AccountService(
            this.Requestor);

        public virtual V2.Core.AccountLinkService AccountLinks => this.accountLinks ??= new V2.Core.AccountLinkService(
            this.Requestor);

        public virtual V2.Core.AccountTokenService AccountTokens => this.accountTokens ??= new V2.Core.AccountTokenService(
            this.Requestor);

        public virtual V2.Core.ClaimableSandboxService ClaimableSandboxes => this.claimableSandboxes ??= new V2.Core.ClaimableSandboxService(
            this.Requestor);

        public virtual V2.Core.EventService Events => this.events ??= new V2.Core.EventService(
            this.Requestor);

        public virtual V2.Core.EventDestinationService EventDestinations => this.eventDestinations ??= new V2.Core.EventDestinationService(
            this.Requestor);

        public virtual V2.Core.VaultService Vault => this.vault ??= new V2.Core.VaultService(
            this.Requestor);
    }
}
