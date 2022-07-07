using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IEventBus bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            this.accountRepository = accountRepository;
            this.bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }

        public void TransferFunds(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                     from: accountTransfer.FromAccount,
                     to: accountTransfer.ToAccount,
                     amount: accountTransfer.Amount
                );

            bus.SendCommand(createTransferCommand);
        }
    }
}
