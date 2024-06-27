using Microrabbit.Banking.Domain.Interfaces;
using Microrabbit.Banking.Domain.Models;
using MicroRabbit.Banking.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return this.accountRepository.GetAccounts();
        }
    }
}
