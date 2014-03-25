using insitu.contracts.open;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insitu.services.open
{
    public class MerchantService : IMerchantContract
    {
        int IMerchantContract.CreateMercantes(data.entities.Mercantes broker)
        {
            throw new NotImplementedException();
        }

        List<data.entities.Mercantes> IMerchantContract.ReadMercantes()
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.UpdateMercantes(data.entities.Mercantes broker)
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.DeleteMercantes(int id)
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.CreateProductos(data.entities.Productos broker)
        {
            throw new NotImplementedException();
        }

        List<data.entities.Productos> IMerchantContract.ReadProductos()
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.UpdateProductos(data.entities.Productos broker)
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.DeleteProductos(int id)
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.CreatePromociones(data.entities.Promociones broker)
        {
            throw new NotImplementedException();
        }

        List<data.entities.Promociones> IMerchantContract.ReadPromociones()
        {
            throw new NotImplementedException();
        }

        List<data.entities.Promociones> IMerchantContract.ReadPromocionesPorCategorias(List<int> Collection)
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.UpdatePromociones(data.entities.Promociones broker)
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.DeletePromociones(int id)
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.CreateItemProductos(data.entities.ItemProductos broker)
        {
            throw new NotImplementedException();
        }

        List<data.entities.ItemProductos> IMerchantContract.ReadItemProductos(int Mercante)
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.UpdateItemProductos(data.entities.ItemProductos broker)
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.DeleteItemProductos(int id)
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.CreateClientesMercantes(data.entities.ClientesMercantes broker)
        {
            throw new NotImplementedException();
        }

        int IMerchantContract.DeleteClientesMercantes(int id)
        {
            throw new NotImplementedException();
        }

        List<data.entities.ClientesMercantes> IMerchantContract.ReadClientesMercantes(int Mercante)
        {
            throw new NotImplementedException();
        }
    }
}
