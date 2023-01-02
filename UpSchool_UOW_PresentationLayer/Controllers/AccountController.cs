using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_UOW_BusinessLayer.Abstract;
using UpSchool_UOW_DataAccessLayer.Concrete;
using UpSchool_UOW_EntityLayer.Concrete;
using UpSchool_UOW_PresentationLayer.Models;

namespace UpSchool_UOW_PresentationLayer.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel p)
        {
            var value1 = _accountService.TGetByID(p.SenderID);
            var value2 = _accountService.TGetByID(p.ReceiverID);

            value1.AccountBalance -= p.Amount;
            value2.AccountBalance += p.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                value1,
                value2
            };
            _accountService.TMultiUpdate(modifiedAccounts);
            return View();
        }
    }
}
