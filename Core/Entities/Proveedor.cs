using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Proveedor : BaseEntity
{
    public string Nombre { get; set; }
    public int NitProveedor { get; set; }
    public int IdTipoPersona { get; set; }
    public TipoPersona TiposPersonas { get; set; }
    public int IdMunicipio { get; set; }
    public Municipio Municipios { get; set; }
    public ICollection<InsumoProveedor> InsumosProveedores { get; set; }
}
