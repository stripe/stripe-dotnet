using System.Collections.Generic;

namespace Stripe
{
	public class StripeRefundService : StripeService
	{
		public StripeRefundService(string apiKey = null) : base(apiKey) { }

		public bool ExpandBalanceTransaction { get; set; }
		public bool ExpandCustomer { get; set; }
		public bool ExpandInvoice { get; set; }

		public virtual StripeRefund Create(string chargeId, StripeRefundCreateOptions createOptions)
		{
            var url = string.Format(Urls.Refunds, chargeId);
			url = this.ApplyAllParameters(createOptions, url, false);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeRefund>.MapFromJson(response);
		}

        public virtual StripeRefund Get(string chargeId, string refundId)
		{
            var chargeUrl = string.Format(Urls.Refunds, chargeId);
            var url = string.Format("{0}/{1}", chargeUrl, refundId);
            url = this.ApplyAllParameters(null, url, false);

			var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeRefund>.MapFromJson(response);
		}

		public virtual IEnumerable<StripeRefund> List(string chargeId, StripeListOptions listOptions = null)
		{
            var url = string.Format(Urls.Refunds, chargeId);
            url = this.ApplyAllParameters(listOptions, url, true);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeRefund>.MapCollectionFromJson(response);
		}
	}
}
