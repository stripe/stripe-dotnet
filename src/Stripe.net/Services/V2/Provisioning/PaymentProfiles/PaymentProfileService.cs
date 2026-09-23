// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentProfileService : Service
    {
        internal PaymentProfileService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PaymentProfileService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves the payment profile for the current project.
        /// </summary>
        public virtual PaymentProfile Get(PaymentProfileGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentProfile>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/payment_profile", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the payment profile for the current project.
        /// </summary>
        public virtual Task<PaymentProfile> GetAsync(PaymentProfileGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentProfile>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/payment_profile", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates the usage limit on the payment profile for a provider.
        /// </summary>
        public virtual PaymentProfile UpdateLimit(PaymentProfileUpdateLimitOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentProfile>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/payment_profile/update_limit", options, requestOptions);
        }

        /// <summary>
        /// Updates the usage limit on the payment profile for a provider.
        /// </summary>
        public virtual Task<PaymentProfile> UpdateLimitAsync(PaymentProfileUpdateLimitOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentProfile>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/payment_profile/update_limit", options, requestOptions, cancellationToken);
        }
    }
}
