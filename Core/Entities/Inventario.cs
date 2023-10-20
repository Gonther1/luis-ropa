using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Inventario : BaseEntity
{
    public int CodInv { get; set; }
    public int IdPrenda { get; set; }
    public Prenda Prendas { get; set; }
    public int ValorVtaCop { get; set; }
    public int ValorVtaUsd { get; set; }
    public ICollection<InventarioTalla> InventarioTallas { get; set; }
    public ICollection<DetalleVenta> DetallesVentas { get; set; }
}
