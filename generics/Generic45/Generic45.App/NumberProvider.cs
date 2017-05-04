using System.Collections.Generic;

namespace Generic45.App
{
    /// <summary>
    /// Number provider.
    /// </summary>
    public class NumberProvider : IValueProvider
    {
        /// <inheritdoc />
        public int GetValue()
        {
            return 42;
        }

        /// <inheritdoc />
        public IEnumerable<int> GetValues()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
}
