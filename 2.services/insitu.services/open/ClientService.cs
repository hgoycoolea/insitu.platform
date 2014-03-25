using insitu.contracts.open;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.services.open
{
    public class ClientService : IClientContract
    {
        List<data.entities.Promociones> IClientContract.ReadPromociones()
        {
            throw new NotImplementedException();
        }

        List<data.entities.Promociones> IClientContract.ReadPromocionesPorCategorias(List<int> Collection)
        {
            throw new NotImplementedException();
        }

        List<data.entities.Promociones> IClientContract.ReadPromocionesPorGeolocation(string axis)
        {
            throw new NotImplementedException();
        }

        int IClientContract.CreateVisita(data.entities.Visitas broker)
        {
            throw new NotImplementedException();
        }

        List<data.entities.Membresias> IClientContract.ReadMembresias()
        {
            throw new NotImplementedException();
        }

        int IClientContract.CreateCategoriasClientes(data.entities.CategoriasClientes broker)
        {
            throw new NotImplementedException();
        }

        List<data.entities.CategoriasClientes> IClientContract.ReadCategoriasClientes(int Cliente)
        {
            throw new NotImplementedException();
        }
    }
}
