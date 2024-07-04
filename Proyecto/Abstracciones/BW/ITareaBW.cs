using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.BW
{
    public interface ITareaBW
    {
        Task<Guid> Agregar(Tarea tarea);
        Task<Guid> Editar(Tarea tarea);
        Task<Guid> Eliminar(Guid Id);
        Task<IEnumerable<Tarea>> Obtener();
        Task<IEnumerable<Tarea>> ObtenerPorCreador(Guid Creador);
    }
}
