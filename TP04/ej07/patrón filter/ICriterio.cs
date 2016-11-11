using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej07.patrón_filter
{
    public interface ICriterio
    {
        IList<Evento> cumpleCriterio();
    }
}
