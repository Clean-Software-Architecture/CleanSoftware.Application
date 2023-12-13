using MediatR;

namespace CleanSoftware.Application.Interfaces
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {
    }
}
