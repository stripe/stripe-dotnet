// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ActiveEntitlementService : Service<ActiveEntitlement>,
        IListable<ActiveEntitlement, ActiveEntitlementListOptions>,
        IRetrievable<ActiveEntitlement, ActiveEntitlementGetOptions>
    {
        public ActiveEntitlementService()
        {
        }

        public ActiveEntitlementService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/entitlements/active_entitlements";

        /// <summary>
        /// <p>Retrieve an active entitlement</p>.
        /// </summary>
        public virtual ActiveEntitlement Get(string id, ActiveEntitlementGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ActiveEntitlement>(HttpMethod.Get, $"/v1/entitlements/active_entitlements/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve an active entitlement</p>.
        /// </summary>
        public virtual Task<ActiveEntitlement> GetAsync(string id, ActiveEntitlementGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ActiveEntitlement>(HttpMethod.Get, $"/v1/entitlements/active_entitlements/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of active entitlements for a customer</p>.
        /// </summary>
        public virtual StripeList<ActiveEntitlement> List(ActiveEntitlementListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ActiveEntitlement>>(HttpMethod.Get, $"/v1/entitlements/active_entitlements", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of active entitlements for a customer</p>.
        /// </summary>
        public virtual Task<StripeList<ActiveEntitlement>> ListAsync(ActiveEntitlementListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ActiveEntitlement>>(HttpMethod.Get, $"/v1/entitlements/active_entitlements", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of active entitlements for a customer</p>.
        /// </summary>
        public virtual IEnumerable<ActiveEntitlement> ListAutoPaging(ActiveEntitlementListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ActiveEntitlement>($"/v1/entitlements/active_entitlements", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of active entitlements for a customer</p>.
        /// </summary>
        public virtual IAsyncEnumerable<ActiveEntitlement> ListAutoPagingAsync(ActiveEntitlementListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ActiveEntitlement>($"/v1/entitlements/active_entitlements", options, requestOptions, cancellationToken);
        }
    }
}
