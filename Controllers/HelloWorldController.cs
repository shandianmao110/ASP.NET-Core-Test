using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace firstapp.Controllers
{
    public class HelloWorldController : Controller
    {
        public String Welcome(string name,int numTimes=1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name},NumTimes is : {numTimes}");
            
        }
    }
}
