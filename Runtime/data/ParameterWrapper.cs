namespace com.hitapps.services.data
{
    public enum ParamType
    {
        Long,
        Double,
        String
    }

    public struct ParameterWrapper
    {
        private interface IParam
        {
            string Key { get; }
        }

        private struct Param<T> : IParam
        {
            public string Key { get; private set; }
            public T Val { get; private set; }

            public Param(string key, T val) : this()
            {
                Key = key;
            }
        }
        
        private readonly IParam _param;
        public ParamType ParamType { get; private set; }
        public string Key => _param.Key;

        public ParameterWrapper(string key, long value)
        {
            ParamType = ParamType.Long;
            _param = new Param<long>(key, value);
        }

        public ParameterWrapper(string key, double value)
        {
            ParamType = ParamType.Double;
            _param = new Param<double>(key, value);
        }

        public ParameterWrapper(string key, string value)
        {
            ParamType = ParamType.String;
            _param = new Param<string>(key, value);
        }

        public T Val<T>()
        {
            if (_param is Param<T> param)
            {
                return param.Val;
            }

            return default;
        }
    }
}