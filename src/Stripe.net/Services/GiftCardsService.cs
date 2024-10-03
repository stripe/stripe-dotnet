// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class GiftCardsService : Service
    {
        private GiftCards.CardService cards;
        private GiftCards.TransactionService transactions;

        internal GiftCardsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal GiftCardsService(IStripeClient client)
            : base(client)
        {
        }

        public virtual GiftCards.CardService Cards => this.cards ??= new GiftCards.CardService(
            this.Requestor);

        public virtual GiftCards.TransactionService Transactions => this.transactions ??= new GiftCards.TransactionService(
            this.Requestor);
    }
}
