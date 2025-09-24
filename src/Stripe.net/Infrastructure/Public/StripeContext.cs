namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Represents a path-like context for Stripe API operations, allowing for
    /// hierarchical organization of API calls. The context is externally immutable,
    /// meaning all operations return new instances rather than modifying existing ones.
    /// </summary>
    public class StripeContext
    {
        private readonly ReadOnlyCollection<string> segments;

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeContext"/> class.
        /// </summary>
        public StripeContext()
            : this(new List<string>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeContext"/> class.
        /// </summary>
        /// <param name="segments">The segments that make up the context.</param>
        public StripeContext(IEnumerable<string> segments)
        {
            this.segments = new ReadOnlyCollection<string>(segments?.ToList() ?? new List<string>());
        }

        /// <summary>
        /// Parses a context string into a StripeContext instance.
        /// </summary>
        /// <param name="contextString">The context string to parse.</param>
        /// <returns>A new StripeContext instance.</returns>
        public static StripeContext Parse(string contextString)
        {
            if (string.IsNullOrEmpty(contextString))
            {
                return new StripeContext();
            }

            return new StripeContext(contextString.Split('/'));
        }

        /// <summary>
        /// Returns the parent context by removing the last segment.
        /// Throws an exception if the context is empty.
        /// </summary>
        /// <returns>A new StripeContext instance representing the parent.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the context is empty.</exception>
        public StripeContext Parent()
        {
            if (this.segments.Count == 0)
            {
                throw new InvalidOperationException("Cannot get parent of empty context");
            }

            return new StripeContext(this.segments.Take(this.segments.Count - 1));
        }

        /// <summary>
        /// Returns a new context with the given segment appended.
        /// </summary>
        /// <param name="segment">The segment to append.</param>
        /// <returns>A new StripeContext instance with the segment appended.</returns>
        public StripeContext Child(string segment)
        {
            var newSegments = new List<string>(this.segments) { segment };
            return new StripeContext(newSegments);
        }

        /// <summary>
        /// Returns the string representation of the context.
        /// </summary>
        /// <returns>The context as a forward-slash separated string.</returns>
        public override string ToString()
        {
            return string.Join("/", this.segments);
        }
    }
}