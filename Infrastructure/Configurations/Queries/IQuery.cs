using MediatR;

namespace Project.Infrastructure.Configurations.Queries
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {

    }
}
