namespace Stripe
{
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

        public virtual ApplicationFee Get(string id, ApplicationFeeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<ApplicationFee> GetAsync(string id, ApplicationFeeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ApplicationFee> List(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ApplicationFee>> ListAsync(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ApplicationFee> ListAutoPaging(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<ApplicationFee> ListAutoPagingAsync(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif
    }
}
