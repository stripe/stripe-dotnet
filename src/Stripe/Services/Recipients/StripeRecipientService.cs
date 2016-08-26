using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    [Obsolete("This service has been deprecated by Stripe for sometime, and it will be removed in 7.0. Use Connect instead.")]
    public class StripeRecipientService : StripeService
    {
        public StripeRecipientService(string apiKey = null) : base(apiKey) { }

        public bool ExpandDefaultCard { get; set; }

        public virtual StripeRecipient Create(StripeRecipientCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRecipient>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.Recipients, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeRecipient Get(string recipientId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRecipient>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Recipients}/{recipientId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeRecipient Update(string recipientId, StripeRecipientUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRecipient>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Recipients}/{recipientId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual void Delete(string recipientId, StripeRequestOptions requestOptions = null)
        {
            Requestor.Delete($"{Urls.Recipients}/{recipientId}",
                SetupRequestOptions(requestOptions));
        }

        public virtual IEnumerable<StripeRecipient> List(StripeRecipientListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRecipient>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Recipients, true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeRecipient> CreateAsync(StripeRecipientCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRecipient>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Recipients, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeRecipient> GetAsync(string recipientId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRecipient>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Recipients}/{recipientId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeRecipient> UpdateAsync(string recipientId, StripeRecipientUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRecipient>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Recipients}/{recipientId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async void DeleteAsync(string recipientId, StripeRequestOptions requestOptions = null)
        {
            await Requestor.DeleteAsync($"{Urls.Recipients}/{recipientId}",
                SetupRequestOptions(requestOptions));
        }

        public virtual async Task<IEnumerable<StripeRecipient>> ListAsync(StripeRecipientListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeRecipient>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Recipients, true),
                SetupRequestOptions(requestOptions))
            );
        }
    }
}
