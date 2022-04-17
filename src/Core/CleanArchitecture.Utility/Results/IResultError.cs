namespace CleanArchitecture.Utility.Results;

public interface IResultError
{
  string Error { get; }
  string Code { get; }
}
