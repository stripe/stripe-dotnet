using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeRefundService : StripeService
    {
        public StripeRefundService(string apiKey = null) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }

        public virtual StripeRefund Create(string chargeId, StripeRefundCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, $"{Urls.Charges}/{chargeId}/refunds", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeRefund Get(string chargeId, string refundId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Charges}/{chargeId}/refunds/{refundId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeRefund Update(string chargeId, string refundId, StripeRefundUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Charges}/{chargeId}/refunds/{refundId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeRefund> List(string chargeId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, $"{Urls.Charges}/{chargeId}/refunds", true),
                SetupRequestOptions(requestOptions))
            );
        }

#if !PORTABLE
        public virtual async Task<StripeRefund> CreateAsync(string chargeId, StripeRefundCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, $"{Urls.Charges}/{chargeId}/refunds", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeRefund> GetAsync(string chargeId, string refundId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Charges}/{chargeId}/refunds/{refundId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeRefund> UpdateAsync(string chargeId, string refundId, StripeRefundUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Charges}/{chargeId}/refunds/{refundId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<IEnumerable<StripeRefund>> ListAsync(string chargeId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRefund>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, $"{Urls.Charges}/{chargeId}/refunds", true),
                SetupRequestOptions(requestOptions))
            );
        }
#endif
    }
}
