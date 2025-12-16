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
        private Issuing.CreditUnderwritingRecordService creditUnderwritingRecords;
        private Issuing.DisputeService disputes;
        private Issuing.DisputeSettlementDetailService disputeSettlementDetails;
        private Issuing.FraudLiabilityDebitService fraudLiabilityDebits;
        private Issuing.PersonalizationDesignService personalizationDesigns;
        private Issuing.PhysicalBundleService physicalBundles;
        private Issuing.ProgramService programs;
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

        public virtual Issuing.CreditUnderwritingRecordService CreditUnderwritingRecords => this.creditUnderwritingRecords ??= new Issuing.CreditUnderwritingRecordService(
            this.Requestor);

        public virtual Issuing.DisputeService Disputes => this.disputes ??= new Issuing.DisputeService(
            this.Requestor);

        public virtual Issuing.DisputeSettlementDetailService DisputeSettlementDetails => this.disputeSettlementDetails ??= new Issuing.DisputeSettlementDetailService(
            this.Requestor);

        public virtual Issuing.FraudLiabilityDebitService FraudLiabilityDebits => this.fraudLiabilityDebits ??= new Issuing.FraudLiabilityDebitService(
            this.Requestor);

        public virtual Issuing.PersonalizationDesignService PersonalizationDesigns => this.personalizationDesigns ??= new Issuing.PersonalizationDesignService(
            this.Requestor);

        public virtual Issuing.PhysicalBundleService PhysicalBundles => this.physicalBundles ??= new Issuing.PhysicalBundleService(
            this.Requestor);

        public virtual Issuing.ProgramService Programs => this.programs ??= new Issuing.ProgramService(
            this.Requestor);

        public virtual Issuing.TokenService Tokens => this.tokens ??= new Issuing.TokenService(
            this.Requestor);

        public virtual Issuing.TransactionService Transactions => this.transactions ??= new Issuing.TransactionService(
            this.Requestor);
    }
}
