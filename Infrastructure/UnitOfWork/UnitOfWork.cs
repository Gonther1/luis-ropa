using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly LuisRopaContext _context;
    private readonly CargoRepository _cargos;
    private readonly ClienteRepository _clientes;
    private readonly ColorRepository _colores;
    private readonly DepartamentoRepository _departamentos;
    private readonly DetalleOrdenRepository _detallesordenes;
    private readonly DetalleVentaRepository _detallersventas;
    private readonly EmpleadoRepository _empleados;
    private readonly EmpresaRepository _empresas;
    private readonly EstadoRepository _estados;
    private readonly FormaPagoRepository _formaspagos;
    private readonly GeneroRepository _generos;
    private readonly InsumoRepository _insumos;
    private readonly InventarioRepository _inventarios;
    private readonly MunicipioRepository _municipios;
    private readonly OrdenRepository _ordenes;
    private readonly PaisRepository _paises;
    private readonly PrendaRepository _prendas;
    private readonly ProveedorRepository _proveedores;
    private readonly TallaRepository _tallas;
    private readonly TipoPersonaRepository _tipospersonas;
    private readonly TipoProteccionRepository _tipoprotecciones;
    private readonly VentaRepository _ventas;
    /* private readonly VentaRepository _ventas; */
/*     public ICargoRepository Cargos
    {
        get 
        {
            if (_cargos == null)
            {
                _cargos = new VentaRepository(_context);
            }
            return _cargos;
        }
    } */
    
    public ICargoRepository Cargo
    {
        get 
        {
            if (_cargos == null)
            {
                _cargos = new CargoRepository(_context);
            }
            return _cargos;
        }
    }
        public IClienteRepository Cliente
    {
        get 
        {
            if (_clientes == null)
            {
                _clientes = new ClienteRepository(_context);
            }
            return _clientes;
        }
    }
public IColorRepository Color
    {
        get 
        {
            if (_colores == null)
            {
                _colores = new ColorRepository(_context);
            }
            return _colores;
        }
    }
        public IDepartamentoRepository Departamento
    {
        get 
        {
            if (_departamentos == null)
            {
                _departamentos = new DepartamentoRepository(_context);
            }
            return _departamentos;
        }
    }
        public IDetalleOrdenRepository DetalleOrden
    {
        get 
        {
            if (_detallesordenes == null)
            {
                _detallesordenes = new DetalleOrdenRepository(_context);
            }
            return _detallesordenes;
        }
    }
        public IDetalleVentaRepository DetalleVenta
    {
        get 
        {
            if (_detallersventas == null)
            {
                _detallersventas = new DetalleVentaRepository(_context);
            }
            return _detallersventas;
        }
    }
        public IEmpleadoRepository Empleado
    {
        get 
        {
            if (_empleados == null)
            {
                _empleados = new EmpleadoRepository(_context);
            }
            return _empleados;
        }
    }
        public IEmpresaRepository Empresa
    {
        get 
        {
            if (_empresas == null)
            {
                _empresas = new EmpresaRepository(_context);
            }
            return _empresas;
        }
    }
        public IEstadoRepository Estado
    {
        get 
        {
            if (_estados == null)
            {
                _estados = new EstadoRepository(_context);
            }
            return _estados;
        }
    }
        public IFormaPagoRepository FormaPago
    {
        get 
        {
            if (_formaspagos == null)
            {
                _formaspagos = new FormaPagoRepository(_context);
            }
            return _formaspagos;
        }
    }

        public IGeneroRepository Genero
    {
        get 
        {
            if (_generos == null)
            {
                _generos = new GeneroRepository(_context);
            }
            return _generos;
        }
    }
        public IInsumoRepository Insumo
    {
        get 
        {
            if (_insumos == null)
            {
                _insumos = new InsumoRepository(_context);
            }
            return _insumos;
        }
    }
        public IInventarioRepository Inventario
    {
        get 
        {
            if (_inventarios == null)
            {
                _inventarios = new InventarioRepository(_context);
            }
            return _inventarios;
        }
    }
        public IMunicipioRepository Municipio
    {
        get 
        {
            if (_municipios == null)
            {
                _municipios = new MunicipioRepository(_context);
            }
            return _municipios;
        }
    }
    public IOrdenRepository Orden
    {
        get 
        {
            if (_ordenes == null)
            {
                _ordenes = new OrdenRepository(_context);
            }
            return _ordenes;
        }
    }
        public IPaisRepository Pais
    {
        get 
        {
            if (_paises == null)
            {
                _paises = new PaisRepository(_context);
            }
            return _paises;
        }
    }
        public IPrendaRepository Prenda
    {
        get 
        {
            if (_prendas == null)
            {
                _prendas = new PrendaRepository(_context);
            }
            return _prendas;
        }
    }
        public IProveedorRepository Proveedor
    {
        get 
        {
            if (_proveedores == null)
            {
                _proveedores = new ProveedorRepository(_context);
            }
            return _proveedores;
        }
    }
        public ITallaRepository Talla
    {
        get 
        {
            if (_tallas == null)
            {
                _tallas = new ITallaRepository(_context);
            }
            return _tallas;
        }
    }
        public ITipoPersonaRepository TipoPersona
    {
        get 
        {
            if (_tipospersonas == null)
            {
                _tipospersonas = new TipoPersonaRepository(_context);
            }
            return _tipospersonas;
        }
    }
        public ITipoProteccionRepository TipoProteccion
    {
        get 
        {
            if (_tipoprotecciones == null)
            {
                _tipoprotecciones = new TipoProteccionRepository(_context);
            }
            return _tipoprotecciones;
        }
    }
        public IVentaRepository Venta
    {
        get 
        {
            if (_ventas == null)
            {
                _ventas = new VentaRepository(_context);
            }
            return _ventas;
        }
    }

    
    public UnitOfWork(LuisRopaContext context)
    {
        _context = context;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveAsync()
    {
        throw new NotImplementedException();
    }
}
