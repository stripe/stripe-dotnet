// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class IssuingService : Service
    {
        private TestHelpers.Issuing.AuthorizationService authorizations;
        private TestHelpers.Issuing.CardService cards;
        private TestHelpers.Issuing.PersonalizationDesignService personalizationDesigns;
        private TestHelpers.Issuing.TransactionService transactions;

        internal IssuingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal IssuingService(IStripeClient client)
            : base(client)
        {
        }

        public virtual TestHelpers.Issuing.AuthorizationService Authorizations => this.authorizations ??= new TestHelpers.Issuing.AuthorizationService(
            this.Requestor);

        public virtual TestHelpers.Issuing.CardService Cards => this.cards ??= new TestHelpers.Issuing.CardService(
            this.Requestor);

        public virtual TestHelpers.Issuing.PersonalizationDesignService PersonalizationDesigns => this.personalizationDesigns ??= new TestHelpers.Issuing.PersonalizationDesignService(
            this.Requestor);

        public virtual TestHelpers.Issuing.TransactionService Transactions => this.transactions ??= new TestHelpers.Issuing.TransactionService(
            this.Requestor);
    }
}
