using GraphQL;
using GraphQL.Types;

class WeatherForecastSchema : Schema
{
    public WeatherForecastSchema(IDependencyResolver resolver) : base (resolver)
    {
        Query = resolver.Resolve<WeatherForecastQuery>();
    }
}