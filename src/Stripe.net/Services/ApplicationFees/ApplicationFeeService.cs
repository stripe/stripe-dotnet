namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ApplicationFeeService : Service<ApplicationFee>,
        IListable<ApplicationFee, ApplicationFeeListOptions>,
        IRetrievable<ApplicationFee>
    {
        public ApplicationFeeService()
            : base(null)
        {
        }

        public ApplicationFeeService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandAccount { get; set; }

        public bool ExpandApplication { get; set; }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandCharge { get; set; }

        public bool ExpandOriginatingTransaction { get; set; }

        public virtual ApplicationFee Get(string applicationFeeId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/application_fees/{applicationFeeId}", requestOptions);
        }

        public virtual Task<ApplicationFee> GetAsync(string applicationFeeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/application_fees/{applicationFeeId}", requestOptions, cancellationToken);
        }

        public virtual StripeList<ApplicationFee> List(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/application_fees", requestOptions, options);
        }

        public virtual Task<StripeList<ApplicationFee>> ListAsync(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/application_fees", requestOptions, cancellationToken, options);
        }
    }
}
