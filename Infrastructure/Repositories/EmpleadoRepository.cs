using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleadoRepository
{
    private readonly LuisRopaContext _context;

    public EmpleadoRepository(LuisRopaContext context) : base(context)
    {
        _context = context;
    }
}
