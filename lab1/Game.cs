using Microsoft.Extensions.Hosting;

namespace lab1;

public class Game : IHostedService {
    private readonly CollisiumSandbox _sandbox;
    public Game(CollisiumSandbox sandbox) {
        _sandbox = sandbox;
    }

    public Task StartAsync(CancellationToken cancellationToken) {
        Console.WriteLine("startAsync");
        const int numExperiments = 1_000_000;

        var winCount = 0;
        for (var i = 0; i < numExperiments; i++) {
            var gameResult = _sandbox.Play();
            if (gameResult) {
                winCount++;
            }
        }
    
        Console.WriteLine(winCount);
        Console.WriteLine((double)winCount/numExperiments);
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken) {
        return Task.CompletedTask;
    }
}