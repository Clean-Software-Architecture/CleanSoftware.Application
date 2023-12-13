using CleanSoftware.Application.Interfaces;

namespace CleanSoftware.Application.Models
{
    public abstract record Query<TResult> : IQuery<TResult>
    {
    }
}
