using System;
using System.Threading.Tasks;

namespace GeniusReferrals.UWP.Utilities
{
    public static class RetryHelper
    {
        public static async Task RetryOnExceptionAsync(
            int times, TimeSpan delay, Func<Task> operation)
        {
            await RetryOnExceptionAsync<Exception>(times, delay, operation);
        }
        public static async Task RetryOnExceptionAsync<TException>(
            int times, TimeSpan delay, Func<Task> operation) where TException : Exception
        {
            if (times < 0)
                throw new ArgumentOutOfRangeException(nameof(times));

            var attempts = -1;
            do
            {
                try
                {
                    attempts++;
                    await operation();
                    break;
                }
                catch (TException ex)
                {
                    if (attempts == times)
                        throw;
                    await TaskEx.Delay(delay);
                }
            } while (true);
        }
    }
}