namespace SF.Core;

public class Result
{
    public List<string> Messages { get; set; } = new List<string>();
    public bool Success { get; set; }
}
public class Result<T> : Result
{
    public T Data { get; set; }
}