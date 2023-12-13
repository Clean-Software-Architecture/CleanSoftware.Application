using MediatR;

namespace CleanSoftware.Application.Interfaces
{
    public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, TResponse> 
        where TCommand : ICommand<TResponse> 
    {
    }
}
