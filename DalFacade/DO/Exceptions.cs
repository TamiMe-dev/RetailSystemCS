
namespace DO;
    [Serializable]
    public class DalIdNotExistsException : Exception
    {
        public DalIdNotExistsException(string message) : base(message) { }
        public DalIdNotExistsException(string message, Exception innerException) : base(message, innerException) { }
    }
    [Serializable]
    public class DalIdExistsException : Exception
    {
        public DalIdExistsException(string message) : base(message) { }
        public DalIdExistsException(string message, Exception innerException) : base(message, innerException) { }

    }

//בנוסף, יש להגדיר חריגות עבור תקלות פנימיות של שכבת BL (לדוג' – קלט לא תקין).