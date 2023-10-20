using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces;

public interface IUnitOfWork
{
    ICargoRepository Cargo { get; }
    IClienteRepository Cliente { get; }
    IColorRepository Color { get; }
    IDepartamentoRepository Departamento { get; }
    IDetalleOrdenRepository DetalleOrden { get; }
    IDetalleVentaRepository DetalleVenta { get; }
    IEmpleadoRepository Empleado { get; }
    IEmpresaRepository Empresa { get; }
    IEstadoRepository Estado { get; }
    IFormaPagoRepository FormaPago { get; }
    IGeneroRepository Genero { get; }
    IInsumoRepository Insumo { get; }
    IInventarioRepository Inventario { get; }
    IMunicipioRepository Municipio { get; }
    IOrdenRepository Orden { get; }
    IPaisRepository Pais { get; }
    IPrendaRepository Prenda { get; }
    IProveedorRepository Proveedor { get; }
    ITallaRepository Talla { get; }
    ITipoPersonaRepository TipoPersona { get; }
    ITipoProteccionRepository TipoProteccion { get; }
    IVentaRepository Venta { get; }
    Task<int> SaveAsync();
}
