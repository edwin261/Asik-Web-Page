using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AsikWeb.Base
{
    public abstract class Base : Controller
    {
        protected IServiceProvider ServiceProvider { get; set; }
        public Base(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
        protected T GetService<T>()
        {
            return (T)ServiceProvider.GetService(typeof(T));
        }
    }
}
