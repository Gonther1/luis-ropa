using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class InsumoRepository : GenericRepository<Insumo>, IInsumoRepository
{
    private readonly LuisRopaContext _context;

    public InsumoRepository(LuisRopaContext context) : base(context)
    {
        _context = context;
    }
}
