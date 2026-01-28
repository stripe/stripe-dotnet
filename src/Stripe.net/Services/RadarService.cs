// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class RadarService : Service
    {
        private Radar.AccountEvaluationService accountEvaluations;
        private Radar.EarlyFraudWarningService earlyFraudWarnings;
        private Radar.PaymentEvaluationService paymentEvaluations;
        private Radar.ValueListService valueLists;
        private Radar.ValueListItemService valueListItems;

        internal RadarService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal RadarService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Radar.AccountEvaluationService AccountEvaluations => this.accountEvaluations ??= new Radar.AccountEvaluationService(
            this.Requestor);

        public virtual Radar.EarlyFraudWarningService EarlyFraudWarnings => this.earlyFraudWarnings ??= new Radar.EarlyFraudWarningService(
            this.Requestor);

        public virtual Radar.PaymentEvaluationService PaymentEvaluations => this.paymentEvaluations ??= new Radar.PaymentEvaluationService(
            this.Requestor);

        public virtual Radar.ValueListService ValueLists => this.valueLists ??= new Radar.ValueListService(
            this.Requestor);

        public virtual Radar.ValueListItemService ValueListItems => this.valueListItems ??= new Radar.ValueListItemService(
            this.Requestor);
    }
}
