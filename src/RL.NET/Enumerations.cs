using System;
using System.Collections.Generic;
using System.Text;

namespace RL.NET
{
    public enum ErrorCode
    {
        Unregistered = 101,
        UnregisteredEnv,
        UnregisteredBenchmark,
        DeprecatedEnv,
        UnseedableEnv,
        DependencyNotInstalled,
        UnsupportedMode,
        ResetNeeded,
        ResetNotAllowed,
        InvalidAction,
        APIConnectionError,
        InvalidRequestError,
        AuthenticationError,
        RateLimitError,
        VideoRecorderError,
        InvalidFrame,
        DoubleWrapperError,
        WrapAfterConfigureError,
        RetriesExceededError,
        AlreadyPendingCallError,
        NoAsyncCallError,
        ClosedEnvironmentError
    }
}
