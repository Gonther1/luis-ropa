using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Prenda : BaseEntity
{
    public int IdPrenda { get; set; }
    public string Nombre { get; set; }
    public int ValorUnitCop { get; set; }
    public int ValorUnitUsd { get; set; }
    public int IdEstado { get; set; }
    public Estado Estados { get; set; }
    public int IdTipoProteccion { get; set; }
    public TipoProteccion TiposProtecciones { get; set; }
    public int IdGenero { get; set; }
    public Genero Generos { get; set; }
    public ICollection<Inventario> Inventarios { get; set; }
    public ICollection<InsumoPrenda> InsumosPrendas { get; set; }
    public ICollection<DetalleOrden> DetallesOrdenes { get; set; }
}
