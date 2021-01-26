using System;

namespace com.hitapps.services.Stub
{
    public abstract class AsyncObserver<T> : IObservable<T>, IDisposable
    {
        private IObserver<T> _observer;
        private T _value;

        protected void SetValue(T config)
        {
            _value = config;
            Apply();
        }

        private void Apply()
        {
            if (_value == null)
                return;
            _observer?.OnNext(_value);
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            _observer = observer;
            Apply();
            return this;
        }

        public abstract void Dispose();
    }
}