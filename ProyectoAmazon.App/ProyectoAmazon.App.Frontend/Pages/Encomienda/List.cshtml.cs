using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoAmazon.App.Persistencia.AppRepositorios;
using ProyectoAmazon.App.Dominio;
 
namespace ProyectoAmazon.App.Frontend.Pages
{
    public class ListEncomiendaModel : PageModel
    {
           
        private readonly RepositorioEncomieda repositorioEncomieda;
        public IEnumerable<Encomieda> Encomieda {get;set;}
 
        public ListBusModel(RepositorioEncomieda repositorioEncomieda)
        {
            this.repositorioEncomieda=repositorioEncomieda;
        }

        public void OnGet()
        {
<<<<<<< HEAD
            Encomieda=repositorioEncomieda.GetAll();
=======
            Encomiendas=repositorioEncomiendas.GetAll();
>>>>>>> 3bd0c21de9008240893dfa68495602d9bf7ed625
        }
    }
}