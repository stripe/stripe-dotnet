namespace Stripe.Radar
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class EarlyFraudWarningService : Service<EarlyFraudWarning>,
        IListable<EarlyFraudWarning, EarlyFraudWarningListOptions>,
        IRetrievable<EarlyFraudWarning>
    {
        public EarlyFraudWarningService()
            : base(null)
        {
        }

        public EarlyFraudWarningService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/radar/early_fraud_warnings";

        public virtual EarlyFraudWarning Get(string earlyFraudWarningId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(earlyFraudWarningId, null, requestOptions);
        }

        public virtual Task<EarlyFraudWarning> GetAsync(string earlyFraudWarningId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(earlyFraudWarningId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<EarlyFraudWarning> List(EarlyFraudWarningListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<EarlyFraudWarning>> ListAsync(EarlyFraudWarningListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<EarlyFraudWarning> ListAutoPaging(EarlyFraudWarningListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
