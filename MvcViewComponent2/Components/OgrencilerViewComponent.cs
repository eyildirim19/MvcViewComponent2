using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcViewComponent2.Components
{
    public class OgrencilerViewComponent : ViewComponent
    {
        public List<string> ogrenciler = new List<string>();

        public IViewComponentResult Invoke(int? tip)
        {
            if (tip == 1) // T
            {
                ogrenciler.Add("Recep");
                ogrenciler.Add("Ekrem");
            }
            else if (tip == 2) // Ç
            {
                ogrenciler.Add("Emre");
                ogrenciler.Add("Ahmet");
            }
            else
            {
                ogrenciler.Add("Bilal");
                ogrenciler.Add("Alper");
            }

            return View(ogrenciler); // geriye view dönen bir metot...
        }

    }
}
