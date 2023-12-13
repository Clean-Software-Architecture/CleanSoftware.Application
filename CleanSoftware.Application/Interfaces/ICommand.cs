using MediatR;

namespace CleanSoftware.Application.Interfaces
{
    public interface ICommand<TResponse> : IRequest<TResponse>
    {
    }
}
