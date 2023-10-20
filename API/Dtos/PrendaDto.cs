using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class PrendaDto
    {
        public int Id { get; set; }
        public int IdPrenda { get; set; }
        public string Nombre { get; set; }
        public int ValorUnitCop { get; set; }
        public int ValorUnitUsd { get; set; }
        public int IdEstado { get; set; }
        public int IdTipoProteccion { get; set; }
        public int IdGenero { get; set; }
    }
}