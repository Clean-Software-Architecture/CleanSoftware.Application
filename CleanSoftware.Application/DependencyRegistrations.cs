using CleanSoftware.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CleanSoftware.Application
{
    public static class DependencyRegistrations
    {
        public static IServiceCollection RegisterApplicationDependencies<TCurrentUser>(
            this IServiceCollection services,
            Func<IServiceProvider, TCurrentUser> currentUserBuilder,
            Action<MediatRServiceConfiguration> mediatorBuilder)
            where TCurrentUser : class, ICurrentUser
        {
            services.AddScoped(p => currentUserBuilder(p));
            services.AddScoped(p => (ICurrentUser)p.GetRequiredService<TCurrentUser>());
            services.AddMediatR(mediatorBuilder);

            return services;
        }
    }
}
