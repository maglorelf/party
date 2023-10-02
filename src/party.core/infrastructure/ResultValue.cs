namespace party.core.infrastructure
{
    using System.Collections.Generic;

    public class ResultValue<T>
    {
        public bool Success { get; init; }
        public int ResultCode { get; init; }
        public T Result { get; init; }
        public IList<string> Errors { get; private set; }

        private ResultValue(bool success, int resultCode, T result)
        {
            Success = success;
            ResultCode = resultCode;
            Result = result;
            Errors = new List<string>();
        }

        private ResultValue(T result)
        {
            Success = true;
            ResultCode = 0;
            Result = result;
            Errors = new List<string>();
        }
        public static ResultValue<T> NewOk() => new(default);
        public static ResultValue<T> NewOk(T result) => new(result);
        public static ResultValue<T> NewError() => new(success: false, resultCode: -1, result: default);
        public static ResultValue<T> NewError(int resultCode) => new(success: false, resultCode, result: default);
        public static ResultValue<T> NewError(T result) => new(success: false, resultCode: -1, result);
        public static ResultValue<T> NewError(int resultCode, T result) => new(success: false, resultCode, result);
        public static ResultValue<T> New(bool success, int resultCode, T result) => new(success, resultCode, result);
        public void AddError(string error)
        {
            Errors.Add(error);
        }
    }
}
