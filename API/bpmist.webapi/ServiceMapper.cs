using Microsoft.Extensions.DependencyInjection;

namespace API
{
    public static class BpmistServiceCollectionExtensions
    {
        public static void AddBpmistServices(this IServiceCollection services)
        {
            services.AddTransient<bpmist.data.ICommands.IGetProcessStartTemplateQuery, bpmist.firestore.Commands.GetProcessStartTemplateQuery>();

        }
    }
}