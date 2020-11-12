using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.RateLocks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// The Loan Rate Lock Apis.
    /// </summary>
    public interface IRateLocks : ILoanApiObject
    {
        /// <summary>
        /// Retrieves rate lock information for a specified request ID in a loan.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LockRequest> GetRateLockAsync(string requestId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves rate lock information for a specified request ID in a loan as raw json.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetRateLockRawAsync(string requestId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the loan snapshot associated with the specified Rate Lock Request.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Dictionary<string, string>> GetRateLockSnapshotAsync(string requestId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the loan snapshot associated with the specified Rate Lock Request as raw json.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetRateLockSnapshotRawAsync(string requestId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves all rate lock requests for the specified loan. To retrieve the "current" rate lock on the loan, look for the rate lock with "lockStatus": "Locked"
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<LockRequest>> GetRateLocksAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves all rate lock requests for the specified loan as raw json. To retrieve the "current" rate lock on the loan, look for the rate lock with "lockStatus": "Locked"
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetRateLocksRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Use this API to create a new rate lock request if you are a Loan Officer. If you are a Secondary user, use this API to perform an action on an existing rate lock request for a specified loan, or submit and confirm a new rate lock request for the loan.
        /// </summary>
        /// <param name="action">Possible actions for a Secondary user include: confirm: Creates and confirms a new rate lock. extend: Extends the confirmed and current rate lock. This creates a new rate lock. relock: Re-locks the confirmed rate lock. This creates a new rate lock. cancel: Cancels a confirmed rate lock request.</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="dataSyncOption">Determines whether the loan will be updated with lock data after a lock is confirmed. Possible values are - noSync: Does not update the loan with lock data upon lock confirmation. - syncLockToLoan: The default value. Updates the loan with the lock data upon lock confirmation.</param>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task SubmitRateLockRequestAsync(RateLockAction action, bool populate, string requestId, DataSyncOption dataSyncOption, LockRequest lockRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Use this API to create a new rate lock request if you are a Loan Officer. If you are a Secondary user, use this API to perform an action on an existing rate lock request for a specified loan, or submit and confirm a new rate lock request for the loan.
        /// </summary>
        /// <param name="action">Possible actions for a Secondary user include: confirm: Creates and confirms a new rate lock. extend: Extends the confirmed and current rate lock. This creates a new rate lock. relock: Re-locks the confirmed rate lock. This creates a new rate lock. cancel: Cancels a confirmed rate lock request.</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="dataSyncOption">Determines whether the loan will be updated with lock data after a lock is confirmed. Possible values are - noSync: Does not update the loan with lock data upon lock confirmation. - syncLockToLoan: The default value. Updates the loan with the lock data upon lock confirmation.</param>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> SubmitRateLockRequestRawAsync(RateLockAction action, bool populate, string requestId, DataSyncOption dataSyncOption, LockRequest lockRequest, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update rate lock request of a specified request ID for a loan. A rate lock request can be updated if it has not been confirmed or denied or cancelled. Updating a rate lock request will not create a new request.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LockRequest> UpdateRateLockRequestAsync(string requestId, LockRequest lockRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update rate lock request of a specified request ID for a loan. A rate lock request can be updated if it has not been confirmed or denied or cancelled. Updating a rate lock request will not create a new request.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateRateLockRequestRawAsync(string requestId, LockRequest lockRequest, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Use this API to confirm a rate lock request. This call releases any existing rate lock on the specified loan and locks the new rate on the loan.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LockRequest> ConfirmRateLockRequestAsync(string requestId, LockRequest lockRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Use this API to confirm a rate lock request. This call releases any existing rate lock on the specified loan and locks the new rate on the loan.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> ConfirmRateLockRequestRawAsync(string requestId, LockRequest lockRequest, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancels an existing lock. Only locks that are recently requested or confirmed can be canceled.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="cancellationDate">Date to cancel the lock.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LockRequest> CancelRateLockRequestAsync(string requestId, DateTime cancellationDate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancels an existing lock. Only locks that are recently requested or confirmed can be canceled.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="cancellationDate">Date to cancel the lock.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CancelRateLockRequestRawAsync(string requestId, DateTime cancellationDate, string? queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Loan Rate Lock Apis.
    /// </summary>
    public sealed class RateLocks : LoanApiObject, IRateLocks
    {
        internal RateLocks(EncompassRestClient client, string loanId)
            : base(client, loanId, "ratelockRequests")
        {
        }

        // TODO
    }
}