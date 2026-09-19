// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning.PaymentProfile
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class UpdateLimitService : Service
    {
        internal UpdateLimitService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal UpdateLimitService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Updates the usage limit on the payment profile for a provider.
        /// </summary>
        public virtual V2.Provisioning.PaymentProfile Update(UpdateLimitUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Provisioning.PaymentProfile>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/payment_profile/update_limit", options, requestOptions);
        }

        /// <summary>
        /// Updates the usage limit on the payment profile for a provider.
        /// </summary>
        public virtual Task<V2.Provisioning.PaymentProfile> UpdateAsync(UpdateLimitUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Provisioning.PaymentProfile>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/payment_profile/update_limit", options, requestOptions, cancellationToken);
        }
    }
}
