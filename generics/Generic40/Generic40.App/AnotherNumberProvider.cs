using Generic40.Domain;
using System.Collections.Generic;

namespace Generic40.App
{
    /// <summary>
    /// Number provider.
    /// </summary>
    public class AnotherNumberProvider : IAnotherValueProvider
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
