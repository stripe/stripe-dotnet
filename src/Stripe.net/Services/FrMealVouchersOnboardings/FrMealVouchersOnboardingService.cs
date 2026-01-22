// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FrMealVouchersOnboardingService : Service,
        ICreatable<FrMealVouchersOnboarding, FrMealVouchersOnboardingCreateOptions>,
        IListable<FrMealVouchersOnboarding, FrMealVouchersOnboardingListOptions>,
        IRetrievable<FrMealVouchersOnboarding, FrMealVouchersOnboardingGetOptions>,
        IUpdatable<FrMealVouchersOnboarding, FrMealVouchersOnboardingUpdateOptions>
    {
        public FrMealVouchersOnboardingService()
        {
        }

        internal FrMealVouchersOnboardingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public FrMealVouchersOnboardingService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a French Meal Vouchers Onboarding object that represents a restaurant’s
        /// onboarding status and starts the onboarding process.</p>.
        /// </summary>
        public virtual FrMealVouchersOnboarding Create(FrMealVouchersOnboardingCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FrMealVouchersOnboarding>(BaseAddress.Api, HttpMethod.Post, $"/v1/fr_meal_vouchers_onboardings", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a French Meal Vouchers Onboarding object that represents a restaurant’s
        /// onboarding status and starts the onboarding process.</p>.
        /// </summary>
        public virtual Task<FrMealVouchersOnboarding> CreateAsync(FrMealVouchersOnboardingCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FrMealVouchersOnboarding>(BaseAddress.Api, HttpMethod.Post, $"/v1/fr_meal_vouchers_onboardings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of a French Meal Vouchers Onboarding object</p>.
        /// </summary>
        public virtual FrMealVouchersOnboarding Get(string id, FrMealVouchersOnboardingGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FrMealVouchersOnboarding>(BaseAddress.Api, HttpMethod.Get, $"/v1/fr_meal_vouchers_onboardings/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a French Meal Vouchers Onboarding object</p>.
        /// </summary>
        public virtual Task<FrMealVouchersOnboarding> GetAsync(string id, FrMealVouchersOnboardingGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FrMealVouchersOnboarding>(BaseAddress.Api, HttpMethod.Get, $"/v1/fr_meal_vouchers_onboardings/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists French Meal Vouchers Onboarding objects</p>.
        /// </summary>
        public virtual StripeList<FrMealVouchersOnboarding> List(FrMealVouchersOnboardingListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<FrMealVouchersOnboarding>>(BaseAddress.Api, HttpMethod.Get, $"/v1/fr_meal_vouchers_onboardings", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists French Meal Vouchers Onboarding objects</p>.
        /// </summary>
        public virtual Task<StripeList<FrMealVouchersOnboarding>> ListAsync(FrMealVouchersOnboardingListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<FrMealVouchersOnboarding>>(BaseAddress.Api, HttpMethod.Get, $"/v1/fr_meal_vouchers_onboardings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists French Meal Vouchers Onboarding objects</p>.
        /// </summary>
        public virtual IEnumerable<FrMealVouchersOnboarding> ListAutoPaging(FrMealVouchersOnboardingListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FrMealVouchersOnboarding>($"/v1/fr_meal_vouchers_onboardings", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists French Meal Vouchers Onboarding objects</p>.
        /// </summary>
        public virtual IAsyncEnumerable<FrMealVouchersOnboarding> ListAutoPagingAsync(FrMealVouchersOnboardingListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FrMealVouchersOnboarding>($"/v1/fr_meal_vouchers_onboardings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the details of a restaurant’s French Meal Vouchers Onboarding object</p>.
        /// </summary>
        public virtual FrMealVouchersOnboarding Update(string id, FrMealVouchersOnboardingUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FrMealVouchersOnboarding>(BaseAddress.Api, HttpMethod.Post, $"/v1/fr_meal_vouchers_onboardings/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the details of a restaurant’s French Meal Vouchers Onboarding object</p>.
        /// </summary>
        public virtual Task<FrMealVouchersOnboarding> UpdateAsync(string id, FrMealVouchersOnboardingUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FrMealVouchersOnboarding>(BaseAddress.Api, HttpMethod.Post, $"/v1/fr_meal_vouchers_onboardings/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
