using Domain.Model.Cuentas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Amnistias
{
    public interface IAministia
    {
        public decimal ObtenerValorDescuento(Cuenta cuenta);
    }
}
