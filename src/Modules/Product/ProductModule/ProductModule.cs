namespace ProductModule
{
    public static class ProductModule
    {
        public static IServiceCollection AddProductModule(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IApplicationBuilder UseProductModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
