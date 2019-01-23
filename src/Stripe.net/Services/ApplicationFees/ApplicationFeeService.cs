namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

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

        public override string BasePath => "/v1/application_fees";

        public bool ExpandAccount { get; set; }

        public bool ExpandApplication { get; set; }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandCharge { get; set; }

        public bool ExpandOriginatingTransaction { get; set; }

        public virtual ApplicationFee Get(string applicationFeeId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(applicationFeeId, null, requestOptions);
        }

        public virtual Task<ApplicationFee> GetAsync(string applicationFeeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(applicationFeeId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<ApplicationFee> List(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ApplicationFee>> ListAsync(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ApplicationFee> ListAutoPaging(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
