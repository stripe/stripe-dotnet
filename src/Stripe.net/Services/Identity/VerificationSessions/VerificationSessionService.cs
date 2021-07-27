// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class VerificationSessionService : Service<VerificationSession>,
        ICreatable<VerificationSession, VerificationSessionCreateOptions>,
        IListable<VerificationSession, VerificationSessionListOptions>,
        IRetrievable<VerificationSession, VerificationSessionGetOptions>,
        IUpdatable<VerificationSession, VerificationSessionUpdateOptions>
    {
        public VerificationSessionService()
            : base(null)
        {
        }

        public VerificationSessionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/identity/verification_sessions";

        public virtual VerificationSession Cancel(string id, VerificationSessionCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions);
        }

        public virtual Task<VerificationSession> CancelAsync(string id, VerificationSessionCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual VerificationSession Create(VerificationSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<VerificationSession> CreateAsync(VerificationSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual VerificationSession Get(string id, VerificationSessionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<VerificationSession> GetAsync(string id, VerificationSessionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<VerificationSession> List(VerificationSessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<VerificationSession>> ListAsync(VerificationSessionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<VerificationSession> ListAutoPaging(VerificationSessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<VerificationSession> ListAutoPagingAsync(VerificationSessionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual VerificationSession Redact(string id, VerificationSessionRedactOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/redact", options, requestOptions);
        }

        public virtual Task<VerificationSession> RedactAsync(string id, VerificationSessionRedactOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/redact", options, requestOptions, cancellationToken);
        }

        public virtual VerificationSession Update(string id, VerificationSessionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<VerificationSession> UpdateAsync(string id, VerificationSessionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
