using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class GeneroRepository : GenericRepository<Genero>, IGeneroRepository
{
    private readonly LuisRopaContext _context;

    public GeneroRepository(LuisRopaContext context) : base(context)
    {
        _context = context;
    }
}
