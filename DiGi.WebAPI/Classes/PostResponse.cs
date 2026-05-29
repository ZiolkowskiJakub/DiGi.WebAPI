namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Represents the response from a POST operation, containing the result, success status, and whether a result was requested.
    /// </summary>
    /// <typeparam name="T">The type of the result contained in the response.</typeparam>
    public class PostResponse<T>
    {
        /// <summary>
        /// Gets the result of the POST operation.
        /// </summary>
        public T? Result { get; }

        /// <summary>
        /// Gets a value indicating whether the POST operation succeeded.
        /// </summary>
        public bool Succeeded { get; }

        /// <summary>
        /// Gets a value indicating whether a result was requested from the POST operation.
        /// </summary>
        public bool ResultRequested { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostResponse{T}"/> class.
        /// </summary>
        /// <param name="succeeded">Whether the operation succeeded.</param>
        /// <param name="resultRequested">Whether a result was requested.</param>
        /// <param name="result">The result of the operation.</param>
        public PostResponse(bool succeeded, bool resultRequested, T? result = default)
        {
            Succeeded = succeeded;
            ResultRequested = resultRequested;
            Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostResponse{T}"/> class.
        /// </summary>
        /// <param name="succeeded">Whether the operation succeeded.</param>
        public PostResponse(bool succeeded)
        {
            Succeeded = succeeded;
            ResultRequested = false;
            Result = default;
        }
    }

    /// <summary>
    /// Represents a non-generic POST response with a boolean result.
    /// </summary>
    public class PostResponse : PostResponse<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostResponse"/> class.
        /// </summary>
        /// <param name="succeeded">Whether the operation succeeded.</param>
        public PostResponse(bool succeeded)
            : base(succeeded, false, succeeded)
        {
        }
    }
}