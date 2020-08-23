using GraphQL.Types;
using POC_GraphQL;

class WeatherForecastType : ObjectGraphType<WeatherForecast>
{
    public WeatherForecastType()
    {
        Field(x => x.Summary);
        Field(x => x.Date);
        Field(x => x.TemperatureC);
        Field(x => x.TemperatureF);
    }
}