using System.Collections.Generic;
using ProyectoAmazon.App.Dominio.Encomienda;
using System.Linq;
using System;

 
/*
public class Encomienda{
        
    public int id { get; set;}
    public string descripcion { get; set;}
    public int peso {get; set;}
    public string tipo {get; set;}
    public string presentacion {get; set;}
} */

namespace ProyectoAmazon.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomienda
    {
        List<Encomiendas> encomiendas;
 
        public RepositorioEncomienda()
        {
            encomiendas= new List<Encomiendas>()
            {
                new Encomiendas{id=1,descriopcion="Camiseta",        peso= 100,   tipo= "ropa",        presentacion= "caja"},
                new Encomiendas{id=2,descriopcion="Disco Duro",      peso= 200,   tipo= "Electronico", presentacion= "caja"},
                new Encomiendas{id=3,descriopcion="Destornilladores",peso= 13,    tipo= "Electronico", presentacion= "caja"}
 
            };
        }
        
        public IEnumerable<Encomiendas> GetAll()  //   *GetAll()* retorna todos  los registros que estan en las ecomiendas
        {
            return Encomienda;
        }
 
        public Encomienda GetBusWithId(int id)
        {  // * GetBusWithId * retorna un registro en especifico filtrado 
            return Encomienda.SingleOrDefault(b => b.id == id);  // * SingleOrDefault* retorna un elemento de una lista 
        }
    }

}
