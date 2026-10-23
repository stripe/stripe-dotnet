// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RewardProgramEnrollmentService : Service
    {
        internal RewardProgramEnrollmentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal RewardProgramEnrollmentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Activates a RewardProgramEnrollment. At most one RewardProgramEnrollment may be active
        /// per Issuer Program globally, across all RewardPrograms. Idempotent: calling this on a
        /// RewardProgramEnrollment that is already active returns 200 with the current object
        /// unchanged.
        /// </summary>
        public virtual RewardProgramEnrollment Activate(string id, RewardProgramEnrollmentActivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RewardProgramEnrollment>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_program_enrollments/{WebUtility.UrlEncode(id)}/activate", options, requestOptions);
        }

        /// <summary>
        /// Activates a RewardProgramEnrollment. At most one RewardProgramEnrollment may be active
        /// per Issuer Program globally, across all RewardPrograms. Idempotent: calling this on a
        /// RewardProgramEnrollment that is already active returns 200 with the current object
        /// unchanged.
        /// </summary>
        public virtual Task<RewardProgramEnrollment> ActivateAsync(string id, RewardProgramEnrollmentActivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RewardProgramEnrollment>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_program_enrollments/{WebUtility.UrlEncode(id)}/activate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Creates a new RewardProgramEnrollment, binding a connected account / Issuer Program to a
        /// RewardProgram. RewardProgramEnrollments are active by default on creation.
        /// </summary>
        public virtual RewardProgramEnrollment Create(RewardProgramEnrollmentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RewardProgramEnrollment>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_program_enrollments", options, requestOptions);
        }

        /// <summary>
        /// Creates a new RewardProgramEnrollment, binding a connected account / Issuer Program to a
        /// RewardProgram. RewardProgramEnrollments are active by default on creation.
        /// </summary>
        public virtual Task<RewardProgramEnrollment> CreateAsync(RewardProgramEnrollmentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RewardProgramEnrollment>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_program_enrollments", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Deactivates a RewardProgramEnrollment. Idempotent: calling this on a
        /// RewardProgramEnrollment that is already inactive returns 200 with the current object
        /// unchanged.
        /// </summary>
        public virtual RewardProgramEnrollment Deactivate(string id, RewardProgramEnrollmentDeactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RewardProgramEnrollment>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_program_enrollments/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions);
        }

        /// <summary>
        /// Deactivates a RewardProgramEnrollment. Idempotent: calling this on a
        /// RewardProgramEnrollment that is already inactive returns 200 with the current object
        /// unchanged.
        /// </summary>
        public virtual Task<RewardProgramEnrollment> DeactivateAsync(string id, RewardProgramEnrollmentDeactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RewardProgramEnrollment>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_program_enrollments/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an existing RewardProgramEnrollment.
        /// </summary>
        public virtual RewardProgramEnrollment Get(string id, RewardProgramEnrollmentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RewardProgramEnrollment>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/reward_program_enrollments/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing RewardProgramEnrollment.
        /// </summary>
        public virtual Task<RewardProgramEnrollment> GetAsync(string id, RewardProgramEnrollmentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RewardProgramEnrollment>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/reward_program_enrollments/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of RewardProgramEnrollments. Omitting <c>reward_program</c> returns
        /// platform-wide enrollments across all RewardPrograms.
        /// </summary>
        public virtual V2.StripeList<RewardProgramEnrollment> List(RewardProgramEnrollmentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<RewardProgramEnrollment>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/reward_program_enrollments", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of RewardProgramEnrollments. Omitting <c>reward_program</c> returns
        /// platform-wide enrollments across all RewardPrograms.
        /// </summary>
        public virtual Task<V2.StripeList<RewardProgramEnrollment>> ListAsync(RewardProgramEnrollmentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<RewardProgramEnrollment>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/reward_program_enrollments", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of RewardProgramEnrollments. Omitting <c>reward_program</c> returns
        /// platform-wide enrollments across all RewardPrograms.
        /// </summary>
        public virtual IEnumerable<RewardProgramEnrollment> ListAutoPaging(RewardProgramEnrollmentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<RewardProgramEnrollment>($"/v2/money_management/reward_program_enrollments", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of RewardProgramEnrollments. Omitting <c>reward_program</c> returns
        /// platform-wide enrollments across all RewardPrograms.
        /// </summary>
        public virtual IAsyncEnumerable<RewardProgramEnrollment> ListAutoPagingAsync(RewardProgramEnrollmentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<RewardProgramEnrollment>($"/v2/money_management/reward_program_enrollments", options, requestOptions, cancellationToken);
        }
    }
}
