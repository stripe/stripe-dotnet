namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    internal static class AsyncUtils
    {
        /// <summary>
        /// Converts an async-enumerable sequence to an enumerable sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam>
        /// <param name="source">An async-enumerable sequence to convert to an enumerable sequence.</param>
        /// <returns>The enumerable sequence containing the elements in the async-enumerable sequence.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
        /// <remarks>
        /// This code is largely borrowed from the System.Linq.Async project (see
        /// https://github.com/dotnet/reactive/blob/7ad606b3dcd4bb2c6ae9622f8a59db7f8f52aa85/Ix.NET/Source/System.Linq.Async/System/Linq/Operators/ToEnumerable.cs).
        /// The reason we're not using System.Linq.Async directly is that it can cause issues with
        /// some versions of EF Core (see https://github.com/stripe/stripe-dotnet/issues/1974).
        /// </remarks>
        public static IEnumerable<TSource> ToEnumerable<TSource>(IAsyncEnumerable<TSource> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var e = source.GetAsyncEnumerator(default);

            try
            {
                while (true)
                {
                    if (!Wait(e.MoveNextAsync()))
                    {
                        break;
                    }

                    yield return e.Current;
                }
            }
            finally
            {
                Wait(e.DisposeAsync());
            }
        }

        private static void Wait(ValueTask task)
        {
            var awaiter = task.GetAwaiter();

            if (!awaiter.IsCompleted)
            {
                task.AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                return;
            }

            awaiter.GetResult();
        }

        private static T Wait<T>(ValueTask<T> task)
        {
            var awaiter = task.GetAwaiter();

            if (!awaiter.IsCompleted)
            {
                return task.AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            }

            return awaiter.GetResult();
        }
    }
}
