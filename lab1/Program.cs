using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Players;
using Shuffler;
using Strategy;

namespace lab1;

static class Solution {

    public static void Main(string[] args) {
        CreateHostBuilder(args).Build().Run();
        Console.WriteLine("here");
    }

    private static IHostBuilder CreateHostBuilder(string[] args) {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) => {
                services.AddHostedService<Game>();
                services.AddScoped<CollisiumSandbox>();
                services.AddScoped<Game>();
                services.AddScoped<ICardShuffler, FisherCardShuffler>();
                services.AddScoped<Player>();
                services.AddScoped<Player>();
                services.AddScoped<IStrategy, FirstCardStrategy>();
                services.AddScoped<IStrategy, FirstCardStrategy>();
            });
    }


    // public static void Main(string[] args) {
   
    // }
}