using Financiera.WebApp.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Financiera.WebApp;

/// <summary>
/// Clase que contiene las configuraciones del contexto Financiera
/// </summary>
public class FinancieraContexto : DbContext 
{
    private readonly string _connectionString;

    /// <summary>
    /// Constructor que recibe la cadena de conexión desde la configuración
    /// </summary>
    public FinancieraContexto(DbContextOptions<FinancieraContexto> options) : base(options)
    {
    }

    /// <summary>
    /// Conjunto de datos Cliente
    /// </summary>
    public DbSet<Cliente> Clientes { get; set; }

    /// <summary>
    /// Conjunto de datos TiposMovimiento
    /// </summary>
    public DbSet<TipoMovimiento> TiposMovimiento { get; set; }

    /// <summary>
    /// Conjunto de datos Cuentas de Ahorro
    /// </summary>
    public DbSet<CuentaAhorro> CuentasAhorro { get; set; }

    /// <summary>
    /// Conjunto de datos de Movimientos de Cuentas
    /// </summary>
    public DbSet<MovimientoCuenta> MovimientosCuenta { get; set; }

    /// <summary>
    /// Configuración de cada entidad hacia la base de datos
    /// </summary>
    /// <param name="modelBuilder">Constructor del modelo</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Mapeos.ClienteConfiguracion());
        modelBuilder.ApplyConfiguration(new Mapeos.TipoMovimientoConfiguracion());
        modelBuilder.ApplyConfiguration(new Mapeos.CuentaAhorroConfiguracion());
        modelBuilder.ApplyConfiguration(new Mapeos.MovimientoCuentaConfiguracion());
    }
}
