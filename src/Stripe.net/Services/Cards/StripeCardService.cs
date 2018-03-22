using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCardService : StripeService
    {
        public StripeCardService() : base(null) { }
        public StripeCardService(string apiKey) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }
        public bool ExpandRecipient { get; set; }



        //Sync
        public virtual StripeCard Create(string customerId, StripeCardCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerId, false);

            return Mapper<StripeCard>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCard Create(string recipientId, StripeCreditCardOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(recipientId, true);

            return Mapper<StripeCard>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCard Get(string customerOrRecipientId, string cardId, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            return Mapper<StripeCard>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCard Update(string customerOrRecipientId, string cardId, StripeCardUpdateOptions updateOptions, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            return Mapper<StripeCard>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeDeleted Delete(string customerOrRecipientId, string cardId, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            return Mapper<StripeDeleted>.MapFromJson(
                Requestor.Delete(url, SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeList<StripeCard> List(string customerOrRecipientId, StripeCardListOptions listOptions = null, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient);

            if (listOptions == null) {
                listOptions = new StripeCardListOptions();
            }

            return Mapper<StripeList<StripeCard>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, url, true),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeCard> CreateAsync(string customerId, StripeCardCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = SetupUrl(customerId, false);

            return Mapper<StripeCard>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, url, false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeCard> CreateAsync(string recipientId, StripeCreditCardOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = SetupUrl(recipientId, true);

            return Mapper<StripeCard>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, url, false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeCard> GetAsync(string customerOrRecipientId, string cardId, bool isRecipient = false, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            return Mapper<StripeCard>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, url, false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeCard> UpdateAsync(string customerOrRecipientId, string cardId, StripeCardUpdateOptions updateOptions, bool isRecipient = false, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            return Mapper<StripeCard>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, url, false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeDeleted> DeleteAsync(string customerOrRecipientId, string cardId, bool isRecipient = false, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            return Mapper<StripeDeleted>.MapFromJson(
                await Requestor.DeleteAsync(url, 
                    SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false)
                );
        }

        public virtual async Task<StripeList<StripeCard>> ListAsync(string customerOrRecipientId, StripeCardListOptions listOptions = null, bool isRecipient = false, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient);

            if (listOptions == null) {
                listOptions = new StripeCardListOptions();
            }

            return Mapper<StripeList<StripeCard>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, url, true),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }



        private string SetupUrl(string customerOrRecipientId, bool isRecipient, string cardId = null)
        {
            var urlParams = string.Format(Urls.CustomerSources, customerOrRecipientId);

            if (isRecipient)
                urlParams = string.Format(Urls.RecipientCards, customerOrRecipientId);

            if (!String.IsNullOrEmpty(cardId))
                return string.Format("{0}/{1}", urlParams, cardId);

            return urlParams;
        }
    }
}
