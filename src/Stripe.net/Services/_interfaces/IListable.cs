namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IListable<T, O>
        where T : IStripeEntity, IHasId
        where O : ListOptions
    {
        StripeList<T> List(O listOptions = null, RequestOptions requestOptions = null);

        Task<StripeList<T>> ListAsync(O listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));

        IEnumerable<T> ListAutoPaging(O listOptions = null, RequestOptions requestOptions = null);
    }
}
