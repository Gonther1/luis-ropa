using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class InventarioDto
    {
        public int Id { get; set; }
        public int CodInv { get; set; }
        public int IdPrenda { get; set; }
        public int ValorVtaCop { get; set; }
        public int ValorVtaUsd { get; set; }
    }
}