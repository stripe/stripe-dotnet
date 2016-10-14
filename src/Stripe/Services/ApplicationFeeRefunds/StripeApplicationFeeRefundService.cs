using System.Threading;
using System.Threading.Tasks;

﻿namespace Stripe
{
    public class StripeApplicationFeeRefundService : StripeBasicService<StripeApplicationFeeRefund>
    {
        public StripeApplicationFeeRefundService(string apiKey = null) : base(apiKey) { }

        // Sync
        public virtual StripeApplicationFeeRefund Create(string applicationFeeId, StripeApplicationFeeRefundCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds", requestOptions, createOptions);
        }



        // Async
        public virtual Task<StripeApplicationFeeRefund> CreateAsync(string applicationFeeId, StripeApplicationFeeRefundCreateOptions createOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds", requestOptions, cancellationToken, createOptions);
        }
    }
}
