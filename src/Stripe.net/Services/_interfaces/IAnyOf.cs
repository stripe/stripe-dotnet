namespace Stripe
{
    using System;

    /// <summary>
    /// Represents a value that may be of one of several different types.
    /// </summary>
    public interface IAnyOf
    {
        /// <summary>Gets the value of the current <see cref="IAnyOf"/> object.</summary>
        /// <returns>The value of the current <see cref="IAnyOf"/> object.</returns>
        object Value { get; }

        /// <summary>Gets the type of the current <see cref="IAnyOf"/> object.</summary>
        /// <returns>The type of the current <see cref="IAnyOf"/> object.</returns>
        Type Type { get; }
    }
}
