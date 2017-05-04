using Generic45.Domain;
using System;
using System.Collections.Generic;

namespace Generic45.AnotherApp
{
    public class RandomNumberProvider : IAnotherValueProvider
    {
        private Random random = new Random();

        /// <inheritdoc />
        public int GetValue()
        {
            return random.Next();
        }

        /// <inheritdoc />
        public IEnumerable<int> GetValues()
        {
            yield return random.Next();
            yield return random.Next();
            yield return random.Next();
        }
    }
}
