using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class VentaRepository : GenericRepository<Venta>, IVentaRepository
{
    private readonly LuisRopaContext _context;

    public VentaRepository(LuisRopaContext context) : base(context)
    {
        _context = context;
    }
}