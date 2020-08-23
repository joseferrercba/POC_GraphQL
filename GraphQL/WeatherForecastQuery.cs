using System;
using System.Collections.Generic;
using System.Linq;
using GraphQL.Types;
using POC_GraphQL;

class WeatherForecastQuery : ObjectGraphType
{
    public WeatherForecastQuery()
    {
        string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        Field<ListGraphType<WeatherForecastType>>("weatherForecast",
                arguments: new QueryArguments(new List<QueryArgument>
                {
                    new QueryArgument<StringGraphType>
                    {
                        Name = "Summary"
                    },
                    new QueryArgument<DateGraphType>
                    {
                        Name = "Date"
                    },
                    new QueryArgument<IntGraphType>
                    {
                        Name = "TemperatureC"
                    },
                    new QueryArgument<IntGraphType>
                    {
                        Name = "TemperatureF"
                    }
                }),
                resolve: context =>
                {                    
                    var rng = new Random();
                    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Now.AddDays(index),
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    })
                    .ToList();                    
                }
            );
    }
}