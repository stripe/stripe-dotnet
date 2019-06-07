namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ApplicationFeeService : Service<ApplicationFee>,
        IListable<ApplicationFee, ApplicationFeeListOptions>,
        IRetrievable<ApplicationFee, ApplicationFeeGetOptions>
    {
        public ApplicationFeeService()
            : base(null)
        {
        }

        public ApplicationFeeService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/application_fees";

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandAccount { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandApplication { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandBalanceTransaction { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandCharge { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandOriginatingTransaction { get; set; }

        public virtual ApplicationFee Get(string applicationFeeId, ApplicationFeeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(applicationFeeId, options, requestOptions);
        }

        public virtual Task<ApplicationFee> GetAsync(string applicationFeeId, ApplicationFeeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(applicationFeeId, options, requestOptions, cancellationToken);
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
