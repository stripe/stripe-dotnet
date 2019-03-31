namespace Stripe
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    /// <summary>Represents a non-generic non-consecutive list.</summary>
    public interface INonConsecutiveList // : IList
    {
        /// <summary>
        /// Gets the read-only dictionary containing the list's indices and values.
        /// </summary>
        /// <value>
        /// The read-only dictionary containing the list's indices and values.
        /// </value>
        ImmutableDictionary<int, object> Dictionary { get; }
    }

    /// <summary>Represents a generic non-consecutive list.</summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    public interface INonConsecutiveList<T> : IList<T>, INonConsecutiveList
    {
        /// <summary>
        /// Gets the read-only dictionary containing the list's indices and values.
        /// </summary>
        /// <value>
        /// The read-only dictionary containing the list's indices and values.
        /// </value>
        new ImmutableDictionary<int, T> Dictionary { get; }
    }
}
