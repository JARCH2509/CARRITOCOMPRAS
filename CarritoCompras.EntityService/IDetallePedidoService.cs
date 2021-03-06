﻿using CarritoCompras.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarritoCompras.EntityService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDetallePedidoService" in both code and config file together.
    [ServiceContract]
    public interface IDetallePedidoService
    {
        [OperationContract]
        List<DetallePedidoEntidad> BuscarDetallePedido();
    }
}
