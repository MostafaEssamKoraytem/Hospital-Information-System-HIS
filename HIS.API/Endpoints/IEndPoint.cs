namespace HIS.API.Endpoints
{
    public interface IEndPoint
    {
        Task MapEndPoint(IEndpointRouteBuilder app);
    }
}
