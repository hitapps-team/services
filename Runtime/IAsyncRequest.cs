using System;

namespace com.hitapps.services
{
    /// <summary>
    /// Async request to anywhere.
    /// </summary>
    /// <typeparam name="TRequest">Request type</typeparam>
    /// <typeparam name="TResult">Result type</typeparam>
    public interface IAsyncRequest<in TRequest, out TResult> : IService
    {
        /// <summary>
        /// Sends request to anywhere
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Observable TResult result</returns>
        IObservable<TResult> Send(TRequest request);
    }
}