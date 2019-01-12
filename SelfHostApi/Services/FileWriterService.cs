using Microsoft.Extensions.Hosting;
using SelfHostApi.Helper;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace SelfHostApi.Services
{
    public class FileWriterService : IHostedService, IDisposable
    {   
        private Timer _timer;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(
                (e) => WriteTimeToFile(),
                null,
                TimeSpan.Zero,
                TimeSpan.FromMinutes(1));

            return Task.CompletedTask;
        }

        public void WriteTimeToFile()
        {
            FileWriter.WriteToFile(DateTime.UtcNow.ToString("O"));
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
