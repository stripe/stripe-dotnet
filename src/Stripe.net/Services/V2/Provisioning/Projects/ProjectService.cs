// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProjectService : Service
    {
        internal ProjectService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ProjectService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a new project.
        /// </summary>
        public virtual Project Create(ProjectCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Project>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/projects", options, requestOptions);
        }

        /// <summary>
        /// Creates a new project.
        /// </summary>
        public virtual Task<Project> CreateAsync(ProjectCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Project>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/projects", options, requestOptions, cancellationToken);
        }
    }
}
