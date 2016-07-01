
using System.Collections.Generic;

namespace Stripe
{
    public class StripeOrderService : StripeService
    {
        public StripeOrderService(string apiKey = null) : base(apiKey) { }

        public virtual StripeOrder Get(string orderId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeOrder>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Orders}/{orderId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeOrder Create(StripeOrderCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeOrder>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.Orders, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeOrder Update(string orderId, StripeOrderUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeOrder>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Orders}/{orderId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeOrder Pay(string orderId, StripeOrderPayOptions payOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeOrder>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(payOptions, $"{Urls.Orders}/{orderId}/pay", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeReturn Return(string orderId, StripeOrderReturnOptions returnOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeReturn>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(returnOptions, $"{Urls.Orders}/{orderId}/returns", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeOrder> List(StripeOrderListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeOrder>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Orders, true),
                SetupRequestOptions(requestOptions))
            );
        }
    }
}
