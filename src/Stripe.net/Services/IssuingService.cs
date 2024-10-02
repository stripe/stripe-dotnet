// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class IssuingService : Service
    {
        private Issuing.AuthorizationService authorizations;
        private Issuing.CardService cards;
        private Issuing.CardholderService cardholders;
        private Issuing.DisputeService disputes;
        private Issuing.PersonalizationDesignService personalizationDesigns;
        private Issuing.PhysicalBundleService physicalBundles;
        private Issuing.TokenService tokens;
        private Issuing.TransactionService transactions;

        internal IssuingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal IssuingService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Issuing.AuthorizationService Authorizations => this.authorizations ??= new Issuing.AuthorizationService(
            this.Requestor);

        public virtual Issuing.CardService Cards => this.cards ??= new Issuing.CardService(
            this.Requestor);

        public virtual Issuing.CardholderService Cardholders => this.cardholders ??= new Issuing.CardholderService(
            this.Requestor);

        public virtual Issuing.DisputeService Disputes => this.disputes ??= new Issuing.DisputeService(
            this.Requestor);

        public virtual Issuing.PersonalizationDesignService PersonalizationDesigns => this.personalizationDesigns ??= new Issuing.PersonalizationDesignService(
            this.Requestor);

        public virtual Issuing.PhysicalBundleService PhysicalBundles => this.physicalBundles ??= new Issuing.PhysicalBundleService(
            this.Requestor);

        public virtual Issuing.TokenService Tokens => this.tokens ??= new Issuing.TokenService(
            this.Requestor);

        public virtual Issuing.TransactionService Transactions => this.transactions ??= new Issuing.TransactionService(
            this.Requestor);
    }
}
