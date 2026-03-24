// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class CapitalService : Service
    {
        private Capital.FinancingOfferService financingOffers;
        private Capital.FinancingSummaryService financingSummary;
        private Capital.FinancingTransactionService financingTransactions;

        internal CapitalService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CapitalService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Capital.FinancingOfferService FinancingOffers => this.financingOffers ??= new Capital.FinancingOfferService(
            this.Requestor);

        public virtual Capital.FinancingSummaryService FinancingSummary => this.financingSummary ??= new Capital.FinancingSummaryService(
            this.Requestor);

        public virtual Capital.FinancingTransactionService FinancingTransactions => this.financingTransactions ??= new Capital.FinancingTransactionService(
            this.Requestor);
    }
}
