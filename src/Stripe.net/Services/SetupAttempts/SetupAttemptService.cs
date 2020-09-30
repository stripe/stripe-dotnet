// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class SetupAttemptService : Service<SetupAttempt>,
        IListable<SetupAttempt, SetupAttemptListOptions>
    {
        public SetupAttemptService()
            : base(null)
        {
        }

        public SetupAttemptService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/setup_attempts";

        public virtual StripeList<SetupAttempt> List(SetupAttemptListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<SetupAttempt>> ListAsync(SetupAttemptListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SetupAttempt> ListAutoPaging(SetupAttemptListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<SetupAttempt> ListAutoPagingAsync(SetupAttemptListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
