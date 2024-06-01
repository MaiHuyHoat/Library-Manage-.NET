using Microsoft.AspNetCore.Mvc;
using QLTV.Data.Model;

namespace QLTV.Controllers
{
    public class BaseController<T> : Controller
    {
        protected manage_libraryContext _DbContext;
        protected Logger<T> _logger;

        public BaseController(manage_libraryContext dbContext, Logger<T> logger)
        {
            _DbContext = dbContext;
            _logger = logger;
        }
    }
}
