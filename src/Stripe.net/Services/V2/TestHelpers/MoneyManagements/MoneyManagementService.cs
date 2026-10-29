// File generated from our OpenAPI spec
namespace Stripe.V2.TestHelpers
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.V2.MoneyManagement;

    public class MoneyManagementService : Service
    {
        internal MoneyManagementService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal MoneyManagementService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a RecipientVerification with a specified match result for testing purposes in a
        /// Sandbox environment.
        /// </summary>
        public virtual V2.MoneyManagement.RecipientVerification RecipientVerifications(MoneyManagementRecipientVerificationsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.RecipientVerification>(BaseAddress.Api, HttpMethod.Post, $"/v2/test_helpers/money_management/recipient_verifications", options, requestOptions);
        }

        /// <summary>
        /// Creates a RecipientVerification with a specified match result for testing purposes in a
        /// Sandbox environment.
        /// </summary>
        public virtual Task<V2.MoneyManagement.RecipientVerification> RecipientVerificationsAsync(MoneyManagementRecipientVerificationsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.RecipientVerification>(BaseAddress.Api, HttpMethod.Post, $"/v2/test_helpers/money_management/recipient_verifications", options, requestOptions, cancellationToken);
        }
    }
}
