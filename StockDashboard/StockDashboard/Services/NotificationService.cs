﻿using StockDashboard.Features.Alpaca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StockDashboard.Services
{
    public class NotificationService : BackgroundService
    {
        private PriceNotificationManager Manager = new PriceNotificationManager();
        //https://medium.com/@daniel.sagita/backgroundservice-for-a-long-running-work-3debe8f8d25b
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            //Do your preparation (e.g. Start code) here
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Run(async () => 
                {
                    await Manager.StartService();
                });             
            }
            //Do your cleanup (e.g. Stop code) here
        }
    }
}
