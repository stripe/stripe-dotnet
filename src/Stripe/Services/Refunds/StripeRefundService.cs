using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeRefundService : StripeService
    {
        public StripeRefundService(string apiKey = null) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandCharge { get; set; }


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

        #region Remove in 7.0
        [Obsolete("The charge id is no longer required.")]
        public virtual StripeRefund Get(string chargeId, string refundId, StripeRequestOptions requestOptions = null)
        {
            return Get(refundId, requestOptions);
        }
        #endregion

        public virtual StripeRefund Update(string refundId, StripeRefundUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.BaseUrl}/refunds/{refundId}"),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        #region Remove in 7.0
        [Obsolete("The charge id is no longer required.")]
        public virtual StripeRefund Update(string chargeId, string refundId, StripeRefundUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Update(refundId, updateOptions, requestOptions);
        }
        #endregion

        public virtual IEnumerable<StripeRefund> List(StripeRefundListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapCollectionFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{Urls.BaseUrl}/refunds", true),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        #region Remove in 7.0
        [Obsolete("The charge id is no longer required.")]
        public virtual IEnumerable<StripeRefund> List(string chargeId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            if (listOptions == null) return List(new StripeRefundListOptions { ChargeId = chargeId }, requestOptions);

            var refundOptions = new StripeRefundListOptions()
            {
                ChargeId = chargeId,
                EndingBefore = listOptions.EndingBefore,
                Limit = listOptions.Limit,
                StartingAfter = listOptions.StartingAfter
            };

            return List(refundOptions, requestOptions);
        }
        #endregion



        //Async
        public virtual async Task<StripeRefund> CreateAsync(string chargeId, StripeRefundCreateOptions createOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeRefund>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, $"{Urls.Charges}/{chargeId}/refunds", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeRefund> GetAsync(string refundId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeRefund>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.BaseUrl}/refunds/{refundId}"),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        #region Remove in 7.0
        [Obsolete("The charge id is no longer required")]
        public virtual async Task<StripeRefund> GetAsync(string chargeId, string refundId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await GetAsync(refundId, requestOptions, cancellationToken);
        }
        #endregion

        public virtual async Task<StripeRefund> UpdateAsync(string refundId, StripeRefundUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeRefund>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.BaseUrl}/refunds/{refundId}"),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        #region Remove in 7.0
        [Obsolete("The charge id is no longer required")]
        public virtual async Task<StripeRefund> UpdateAsync(string chargeId, string refundId, StripeRefundUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await UpdateAsync(refundId, updateOptions, requestOptions, cancellationToken);
        }
        #endregion

        public virtual async Task<IEnumerable<StripeRefund>> ListAsync(StripeRefundListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeRefund>.MapCollectionFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{Urls.BaseUrl}/refunds", true),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        #region Remove in 7.0
        [Obsolete("The charge id is no longer required.")]
        public virtual async Task<IEnumerable<StripeRefund>> ListAsync(string chargeId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (listOptions == null) return await ListAsync(new StripeRefundListOptions { ChargeId = chargeId }, requestOptions, cancellationToken);

            var refundOptions = new StripeRefundListOptions()
            {
                ChargeId = chargeId,
                EndingBefore = listOptions.EndingBefore,
                Limit = listOptions.Limit,
                StartingAfter = listOptions.StartingAfter
            };

            return await ListAsync(refundOptions, requestOptions, cancellationToken);
        }
        #endregion
    }
}
