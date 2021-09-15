using DependencyInversionDemo.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DependencyInversionDemo.Controllers
{
    public class LocalDbController : Controller
    {
        private IRepositoryWrapper _repositoryWrapper;
        public LocalDbController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public IActionResult Index()
        {
            var repo = _repositoryWrapper.RepositoryLocalDb;
            List<string> data= repo.GetData();
            return View(data);
        }
    }
}
