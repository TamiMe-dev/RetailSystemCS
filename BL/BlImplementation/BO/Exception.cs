namespace BO;

    [Serializable]
   
    public class BLIdNotExistsException : Exception
    {
        public BLIdNotExistsException(string? message) : base(message) { }
        public BLIdNotExistsException(string message, Exception innerException) : base(message, innerException) { }
    }
    [Serializable]
    public class BLIdExistsException : Exception
    {
        public BLIdExistsException(string? message) : base(message) { }
        public BLIdExistsException(string message, Exception innerException) : base(message, innerException) { }

    }
    [Serializable]
    public class BLInvalidInputException : Exception
    {
        public BLInvalidInputException(string? message) : base(message) { }
        public BLInvalidInputException(string message, Exception innerException) : base(message, innerException) { }
    }


