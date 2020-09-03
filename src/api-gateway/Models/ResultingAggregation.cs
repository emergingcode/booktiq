namespace api_gateway.Models
{
    public class ResultingAggregation<T> where T : class
    {
        public T Data { get; private set; }
        public bool Success { get; private set; }
        public string Description { get; private set; } = "";

        public ResultingAggregation<T> Ok(T data)
        {
            this.Data = data;
            this.Success = true;

            return this;
        }

        public ResultingAggregation<T> Partial(T data, string description)
        {
            this.Data = data;
            this.Success = false;
            this.Description = description;

            return this;
        }

        public ResultingAggregation<T> Error(string description = "")
        {
            this.Success = false;
            this.Description = description;

            return this;
        }
    }
}