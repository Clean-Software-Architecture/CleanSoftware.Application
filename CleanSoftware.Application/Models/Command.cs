using CleanSoftware.Application.Interfaces;

namespace CleanSoftware.Application.Models
{
    public abstract record Command<TResult> : ICommand<TResult>
    {
    }
}
