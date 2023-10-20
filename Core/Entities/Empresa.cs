using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Empresa : BaseEntity
{
    public int Nit { get; set; }
    public string RazonSocial { get; set; }
    public string RepresentacionLegal { get; set; }
    public DateTime FechaCreacion { get; set; }
    public int IdMun { get; set; }
    public Municipio Municipios { get; set; }
}
