// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class LoginLinkService : ServiceNested<LoginLink>,
        INestedCreatable<LoginLink, LoginLinkCreateOptions>
    {
        public LoginLinkService()
            : base(null)
        {
        }

        public LoginLinkService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/accounts/{PARENT_ID}/login_links";

        public virtual LoginLink Create(string parentId, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<LoginLink>(HttpMethod.Post, $"/v1/accounts/{parentId}/login_links", options, requestOptions);
        }

        public virtual Task<LoginLink> CreateAsync(string parentId, LoginLinkCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<LoginLink>(HttpMethod.Post, $"/v1/accounts/{parentId}/login_links", options, requestOptions, cancellationToken);
        }
    }
}
