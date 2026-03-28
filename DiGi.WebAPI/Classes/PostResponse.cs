namespace DiGi.WebAPI.Classes
{
    public class PostResponse<T>
    {
        public T? Result { get; }

        public bool Succeeded { get; }

        public bool ResultRequested { get; }

        public PostResponse(bool succeeded, bool resultRequested, T? result = default)
        {
            Succeeded = succeeded;
            ResultRequested = resultRequested;
            Result = result;
        }

        public PostResponse(bool succeeded)
        {
            Succeeded = succeeded;
            ResultRequested = false;
            Result = default;
        }
    }

    public class PostResponse : PostResponse<bool>
    {
        public PostResponse(bool succeeded)
            : base(succeeded, false, succeeded)
        {
        }
    }
}