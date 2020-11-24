using Domain.Model.Cuentas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Amnistias
{
    public class AmnistiaCovid : IAministia
    {
        public decimal ObtenerValorDescuento(Cuenta cuenta)
        {
            return cuenta.SaldoDeuda * 0.50m;
        }
    }
}
