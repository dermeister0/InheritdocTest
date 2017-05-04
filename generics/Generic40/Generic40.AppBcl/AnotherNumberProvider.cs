using Generic40.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Generic40.AppBcl
{
    /// <summary>
    /// Number provider.
    /// </summary>
    public class AnotherNumberProvider : IAnotherValueProvider
    {
        /// <inheritdoc />
        public Task DoWorkAsync()
        {
            return TaskEx.FromResult(0);
        }

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
