using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using ParseLibraryNet.DataTransactions;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.Collections.Generic;

namespace SAPDataNetCore
{
    public class Worker : BackgroundService
    {
       private readonly ILogger<Worker> _logger;
        private FileSystemWatcher _folderWatcher;
        private readonly string _writeFolder = @"E:\Shares\SAPData";
        private readonly string _inputFolder;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _inputFolder = @"C:\MyApps\SAPDataNet";

        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.CompletedTask;

            //while (!stoppingToken.IsCancellationRequested)
            //{
            //    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            //    await Task.Delay(1000, stoppingToken);
            //}
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service Starting");
            if (!Directory.Exists(_inputFolder))
            {
                _logger.LogWarning($"Please make sure the InputFolder [{_inputFolder}] exists, then restart the service.");
                return Task.CompletedTask;
            }

            _logger.LogInformation($"Binding Events from Input Folder: {_inputFolder}");
            _folderWatcher = new FileSystemWatcher(_writeFolder, "*.TXT")
            {
                NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.LastWrite | NotifyFilters.FileName |
                                  NotifyFilters.DirectoryName
            };
            _folderWatcher.Created += Input_OnChanged;
            _folderWatcher.Changed += Input_OnChanged;
            _folderWatcher.EnableRaisingEvents = true;

            return base.StartAsync(cancellationToken);
        }
        protected void Input_OnChanged(object source, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Created || e.ChangeType==WatcherChangeTypes.Changed)
            {
                string error = "";
                _logger.LogInformation($"InBound Change Event Triggered by [{e.FullPath}]");
                try
                {
                    //List<string> attr = new List<string>();
                    //attr.Add("ProdOrder");
                    //attr.Add("date add");
                    //attr.Add("889");
                    //attr.Add("34");
                    //attr.Add("44");
                    //attr.Add("date end");
                    //xmlLog.WriteServiceStart();
                    //xmlLog.WriteCompilleStart();
                    //xmlLog.WriteTransaction(attr);   
                    Program.CompileALL();
                }
                catch (Exception ee)
                {
                    txtWriter.Log(ee.ToString(), "Worker",0,0);                  
                }

                _logger.LogInformation($"Done with Inbound Change Event. Error Code: \n{error}");
            }
        }
        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Stopping Service");
            _folderWatcher.EnableRaisingEvents = false;
            await base.StopAsync(cancellationToken);
        }
        public override void Dispose()
        {
            _logger.LogInformation("Disposing Service");
            _folderWatcher.Dispose();
            base.Dispose();
        }
    }
}
