namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The StripeContext class provides an immutable container and convenience methods for
    /// interacting with the <c>Stripe-Context</c> header. All methods return a new instance of StripeContext.
    ///
    /// You can use it whenever you're initializing a <c>StripeClient</c> or sending <c>StripeContext</c> with a request.
    /// It's also found in the <c>EventNotification.context</c> property.
    /// </summary>
    public sealed class StripeContext : IEquatable<StripeContext>
    {
        private readonly IReadOnlyList<string> segments;

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeContext"/> class with no segments.
        /// </summary>
        public StripeContext()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeContext"/> class with the given segments.
        /// </summary>
        /// <param name="segments">Array of context segments (can be null or empty).</param>
        public StripeContext(IEnumerable<string> segments)
        {
            this.segments = (segments ?? Enumerable.Empty<string>()).ToList().AsReadOnly();
        }

        /// <summary>
        /// Gets the segments of this context.
        /// </summary>
        public IReadOnlyList<string> Segments => this.segments;

        /// <summary>
        /// Implicitly converts a string to a StripeContext.
        /// </summary>
        /// <param name="contextStr">The string to convert.</param>
        /// <returns>A new StripeContext instance.</returns>
        public static implicit operator StripeContext(string contextStr)
        {
            if (string.IsNullOrEmpty(contextStr))
            {
                return null;
            }

            return Parse(contextStr);
        }

        /// <summary>
        /// Implicitly converts a StripeContext to a string.
        /// </summary>
        /// <param name="context">The StripeContext to convert.</param>
        /// <returns>The string representation of the context.</returns>
        public static implicit operator string(StripeContext context)
        {
            if (context == null)
            {
                return null;
            }

            if (context.segments.Count == 0)
            {
                return string.Empty;
            }

            return context.ToString();
        }

        /// <summary>
        /// Parses a context string into a StripeContext instance.
        /// </summary>
        /// <param name="contextStr">String to parse (can be null or empty).</param>
        /// <returns>A new StripeContext instance.</returns>
        public static StripeContext Parse(string contextStr)
        {
            if (string.IsNullOrEmpty(contextStr))
            {
                return new StripeContext();
            }

            return new StripeContext(contextStr.Split('/'));
        }

        /// <summary>
        /// Creates a new StripeContext with an additional segment appended.
        /// </summary>
        /// <param name="segment">The segment to append.</param>
        /// <returns>A new StripeContext instance.</returns>
        /// <exception cref="ArgumentNullException">Thrown when segment is null.</exception>
        /// <exception cref="ArgumentException">Thrown when segment is empty or whitespace.</exception>
        public StripeContext Push(string segment)
        {
            if (segment == null)
            {
                throw new ArgumentNullException(nameof(segment));
            }

            if (string.IsNullOrWhiteSpace(segment))
            {
                throw new ArgumentException("Segment cannot be empty or whitespace.", nameof(segment));
            }

            var newSegments = new List<string>(this.segments) { segment };
            return new StripeContext(newSegments);
        }

        /// <summary>
        /// Creates a new StripeContext with the last segment removed.
        /// If there are no segments, returns a new empty StripeContext.
        /// </summary>
        /// <returns>A new StripeContext instance.</returns>
        public StripeContext Pop()
        {
            if (this.segments.Count == 0)
            {
                throw new InvalidOperationException("Cannot pop from an empty StripeContext.");
            }

            var newSegments = this.segments.Take(this.segments.Count - 1);
            return new StripeContext(newSegments);
        }

        /// <summary>
        /// Converts this context to its string representation.
        /// </summary>
        /// <returns>String representation using '/' as separator.</returns>
        public override string ToString()
        {
            return string.Join("/", this.segments);
        }

        /// <summary>
        /// Checks equality with another StripeContext.
        /// </summary>
        /// <param name="other">The other context to compare with.</param>
        /// <returns>true if contexts are equal, false otherwise.</returns>
        public bool Equals(StripeContext other)
        {
            if (other == null)
            {
                return false;
            }

            if (this.segments.Count != other.segments.Count)
            {
                return false;
            }

            return this.segments.SequenceEqual(other.segments);
        }

        /// <summary>
        /// Checks equality with another object.
        /// </summary>
        /// <param name="obj">The object to compare with.</param>
        /// <returns>true if objects are equal, false otherwise.</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as StripeContext);
        }

        /// <summary>
        /// Returns a hash code for this context.
        /// </summary>
        /// <returns>A hash code based on the string representation.</returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
