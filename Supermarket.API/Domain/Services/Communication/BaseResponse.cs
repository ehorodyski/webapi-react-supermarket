namespace Supermarket.API.Domain.Services.Communication
{
  public abstract class BaseResponse
  {
    public bool Success { get; protected set; }
    public string Mesage { get; protected set; }

    public BaseResponse(bool success, string message)
    {
      Success = success;
      Mesage = message;
    }
  }
}