using Abstracciones.BW;
using Abstracciones.DA;
using Abstracciones.BC;
using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW
{
    public class TareaBW : ITareaBW
    {
        private ITareaDA _tareaDA;

        public TareaBW(ITareaDA tareaDA)
        {
            _tareaDA = tareaDA;
        }

        public async Task<Guid> Agregar(Tarea tarea)
        {
            return await _tareaDA.Agregar(tarea);
        }

        public async Task<Guid> Editar(Tarea tarea)
        {
            return await _tareaDA.Editar(tarea);
        }

        public Task<Guid> Eliminar(Guid Id)
        {
            return _tareaDA.Eliminar(Id);
        }

        public Task<IEnumerable<Tarea>> Obtener()
        {
            return _tareaDA.Obtener();
        }

        public Task<IEnumerable<Tarea>> ObtenerPorCreador(Guid Creador)
        {
            return _tareaDA.ObtenerPorCreador(Creador);
        }
    }
}
