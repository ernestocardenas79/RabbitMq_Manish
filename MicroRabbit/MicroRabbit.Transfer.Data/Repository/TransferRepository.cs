using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            this.ctx = ctx;
        }

        public void Add(TransferLog transferLog)
        {
            ctx.Add(transferLog);
            ctx.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return ctx.TransferLogs;
        }
    }
}
