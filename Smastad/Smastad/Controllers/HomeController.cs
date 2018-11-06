using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net;

using Smastad.Models;

namespace Smastad.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult faq()
    {
      return View();
    }

    public IActionResult service()
    {
      return View();
    }

    public IActionResult logIn()
    {
      return View();
    }

    [HttpPost]
    public ViewResult Index (Errand errand)
    {
      if (ModelState.IsValid)
      {
        return View("Errand", errand);
      } else
      {
        return View();
      }
      
    }

    //skapa en cookie
    public ViewResult WriteCookies(string settting, string settingValue, bool isPersistent)
    {
      if (isPersistent)
      {
        CookieOptions options = new CookieOptions();
        options.Expires = DateTime.Now.AddDays(1);
        Response.Cookies.Append(settting, WebUtility.UrlEncode(settingValue), options);
      }
      else
      {
        Response.Cookies.Append(settting, WebUtility.UrlEncode(settingValue));
      }
      ViewBag.Message = "Cookie written successfully!";
      return View("Index");
    }

    //Läsa data från cookien
    public ViewResult ReadCookies()
    {
      ViewBag.FontName = WebUtility.UrlDecode(Request.Cookies["fontName"]);
      ViewBag.FontSize = WebUtility.UrlDecode(Request.Cookies["fontSize"]);
      ViewBag.Color = WebUtility.UrlDecode(Request.Cookies["color"]);

      if (string.IsNullOrEmpty(ViewBag.FontName))
      {
        ViewBag.FontName = "Arial"; //text visas när man klickar Read Cookies
      }
      if (string.IsNullOrEmpty(ViewBag.FontSize))
      {
        ViewBag.FontSize = "22px";
      }
      if (string.IsNullOrEmpty(ViewBag.Color))
      {
        ViewBag.Color = "Blue";
      }
      return View();
    }

  }
}
