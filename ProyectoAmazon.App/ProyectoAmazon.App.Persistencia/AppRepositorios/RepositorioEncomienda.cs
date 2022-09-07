using System.Collections.Generic;
using ProyectoAmazon.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoAmazon.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomienda
    {
        List<Encomienda> Encomienda;
 
    public RepositorioEncomienda()
        {
            Encomienda= new List<Encomienda>()
            {
                new Encomienda{id=1,descriopcion="Camiseta",        peso= 100,   tipo= "ropa",        presentacion= "caja"},
                new Encomienda{id=2,descriopcion="Disco Duro",      peso= 200,   tipo= "Electronico", presentacion= "caja"},
                new Encomienda{id=3,descriopcion="Destornilladores",peso= 13,    tipo= "Electronico", presentacion= "caja"}
 
            };
        }
 
        public IEnumerable<Encomienda> GetAll()  //   *GetAll()* retorna todos  los registros que estan en las ecomiendas
        {
            return Encomienda;
        }
 
        public Encomienda GetBusWithId(int id)
        {  // * GetBusWithId * retorna un registro en especifico filtrado 
            return Encomienda.SingleOrDefault(b => b.id == id);  // * SingleOrDefault* retorna un elemento de una lista 
        }
    }
}
