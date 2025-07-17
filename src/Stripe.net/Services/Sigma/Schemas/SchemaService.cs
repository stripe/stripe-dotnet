// File generated from our OpenAPI spec
namespace Stripe.Sigma
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SchemaService : Service
    {
        public SchemaService()
        {
        }

        internal SchemaService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public SchemaService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Lists the schemas available to the authorized merchant in Stripe’s data products</p>.
        /// </summary>
        public virtual StripeList<Schema> List(SchemaListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Schema>>(BaseAddress.Api, HttpMethod.Get, $"/v1/sigma/schemas", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists the schemas available to the authorized merchant in Stripe’s data products</p>.
        /// </summary>
        public virtual Task<StripeList<Schema>> ListAsync(SchemaListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Schema>>(BaseAddress.Api, HttpMethod.Get, $"/v1/sigma/schemas", options, requestOptions, cancellationToken);
        }
    }
}
