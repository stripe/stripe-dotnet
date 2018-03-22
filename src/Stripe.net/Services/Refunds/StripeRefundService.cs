using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeRefundService : StripeService
    {
        public StripeRefundService() : base(null) { }
        public StripeRefundService(string apiKey) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandCharge { get; set; }
        public bool ExpandFailureBalanceTransaction { get; set; }



        //Sync
        public virtual StripeRefund Create(string chargeId, StripeRefundCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, $"{Urls.Charges}/{chargeId}/refunds", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeRefund Get(string refundId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.BaseUrl}/refunds/{refundId}"),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public virtual StripeRefund Update(string refundId, StripeRefundUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.BaseUrl}/refunds/{refundId}"),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public virtual StripeList<StripeRefund> List(StripeRefundListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeRefund>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{Urls.BaseUrl}/refunds", true),
                    SetupRequestOptions(requestOptions)
                )
            );
        }



        //Async
        public virtual async Task<StripeRefund> CreateAsync(string chargeId, StripeRefundCreateOptions createOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeRefund>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, $"{Urls.Charges}/{chargeId}/refunds", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeRefund> GetAsync(string refundId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeRefund>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.BaseUrl}/refunds/{refundId}"),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                ).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeRefund> UpdateAsync(string refundId, StripeRefundUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeRefund>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.BaseUrl}/refunds/{refundId}"),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                ).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeList<StripeRefund>> ListAsync(StripeRefundListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeRefund>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{Urls.BaseUrl}/refunds", true),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                ).ConfigureAwait(false)
            );
        }
    }
}
