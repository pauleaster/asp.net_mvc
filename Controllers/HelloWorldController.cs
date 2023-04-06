using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public string Welcome(string? name, int? numTimes)
    {
        string? name_string = null;
        string? times_string = null;
        bool empty_response = true;

        if (null != name)
        {
            name_string = $"Hello {name}";
            empty_response = false;
        }
        if (null != numTimes)
        {
            times_string = $"NumTimes is: {numTimes}";
            empty_response = false;
        }

        if (empty_response)
        {
            return HtmlEncoder.Default.Encode($"No options sent");
        }
        else
        {
            return HtmlEncoder.Default.Encode(name_string + " " + times_string);
        }
    }
}