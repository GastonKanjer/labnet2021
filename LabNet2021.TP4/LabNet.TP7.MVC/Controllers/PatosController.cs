using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabNet.TP7.MVC.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Net;
using System.IO;

namespace LabNet.TP7.MVC.Controllers
{
    public class PatosController : Controller
    {


            string baseUrl = "https://random-d.uk/";
            public async Task<ActionResult> Index()
            {
                PatosView pic = new PatosView();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage Res = await client.GetAsync("/api/random");

                    if (Res.IsSuccessStatusCode)
                    {
                        var PicResponse = Res.Content.ReadAsStringAsync().Result;
                        pic = JsonConvert.DeserializeObject<PatosView>(PicResponse);
                    }
                    return View(pic);
                }
            }
        }

    }
