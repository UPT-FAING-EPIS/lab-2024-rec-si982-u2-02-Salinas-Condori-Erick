using Financiera.Dominio.Modelos;

namespace Financiera.WebApp.Modelos
{
    /// <summary>
    /// Entidad de Dominio que representa un tipo de movimiento de cuenta de ahorro
    /// </summary>
    public class TipoMovimiento
    {
        /// <summary>
        /// Representa el identificador del tipo de movimiento
        /// </summary>
        public int IdTipo { get; private set; }

        /// <summary>
        /// Representa la descripcion del tipo de movimiento
        /// </summary>
        public string DescripcionTipo { get; private set; }

        /// <summary>
        /// Método estático para crear un nuevo TipoMovimiento con una descripción.
        /// </summary>
        /// <param name="_descripcion">Descripción del tipo de movimiento</param>
        /// <returns>Instancia de TipoMovimiento</returns>
        /// <exception cref="ArgumentException">Lanza excepción si la descripción es nula o vacía</exception>
        public static TipoMovimiento Crear(string _descripcion)
        {
            if (string.IsNullOrWhiteSpace(_descripcion))
            {
                throw new ArgumentException("La descripción no puede estar vacía o nula.", nameof(_descripcion));
            }

            return new TipoMovimiento
            {
                DescripcionTipo = _descripcion
            };
        }

        /// <summary>
        /// Método estático para crear un nuevo TipoMovimiento con id y descripción.
        /// </summary>
        /// <param name="_id">Identificador del tipo de movimiento</param>
        /// <param name="_descripcion">Descripción del tipo de movimiento</param>
        /// <returns>Instancia de TipoMovimiento</returns>
        /// <exception cref="ArgumentException">Lanza excepción si la descripción es nula o vacía</exception>
        public static TipoMovimiento Crear(int _id, string _descripcion)
        {
            if (string.IsNullOrWhiteSpace(_descripcion))
            {
                throw new ArgumentException("La descripción no puede estar vacía o nula.", nameof(_descripcion));
            }

            return new TipoMovimiento
            {
                IdTipo = _id,
                DescripcionTipo = _descripcion
            };
        }

        // Constructor privado para evitar instanciación directa sin la validación adecuada
        private TipoMovimiento() { }
    }
}
