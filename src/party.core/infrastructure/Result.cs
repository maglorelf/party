namespace party.core.infrastructure
{
    using System.Collections.Generic;
    public class Result
    {
        public bool Success { get; init; }
        public int ResultCode { get; init; }
        public IList<string> Errors { get; private set; }

        private Result(bool success, int resultCode)
        {
            Success = success;
            ResultCode = resultCode;
            Errors = new List<string>();
        }
        private Result()
        {
            Success = true;
            ResultCode = 0;
            Errors = new List<string>();
        }
        public static Result NewOk() => new();
        public static Result NewError(int resultCode) => new(success: false, resultCode);
        public static Result New(bool success, int resultCode) => new(success, resultCode);
        public void AddError(string error)
        {
            Errors.Add(error);
        }
    }
}
