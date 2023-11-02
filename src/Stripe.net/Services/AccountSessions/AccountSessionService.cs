// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountSessionService : Service<AccountSession>,
        ICreatable<AccountSession, AccountSessionCreateOptions>
    {
        public AccountSessionService()
            : base(null)
        {
        }

        public AccountSessionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/account_sessions";

        public virtual AccountSession Create(AccountSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountSession>(HttpMethod.Post, $"/v1/account_sessions", options, requestOptions);
        }

        public virtual Task<AccountSession> CreateAsync(AccountSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountSession>(HttpMethod.Post, $"/v1/account_sessions", options, requestOptions, cancellationToken);
        }
    }
}
