namespace party.test.integrationtest.setup
{
    using System;
    using Microsoft.Extensions.Options;
    using Moq;


    public class TestOptionsMonitor<TOptions> : IOptionsMonitor<TOptions>
    {
        private Action<TOptions, string>? _listener;

        public TestOptionsMonitor(TOptions currentValue)
        {
            CurrentValue = currentValue;
        }

        public TOptions CurrentValue { get; private set; }

        public TOptions Get(string name)
        {
            return CurrentValue;
        }

        public void Set(TOptions value)
        {
            CurrentValue = value;
            _listener?.Invoke(value, string.Empty);
        }

        public IDisposable OnChange(Action<TOptions, string> listener)
        {
            _listener = listener;
            return Mock.Of<IDisposable>();
        }
    }
}
