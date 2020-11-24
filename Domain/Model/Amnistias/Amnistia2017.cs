using Domain.Model.Cuentas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Amnistias
{
    public class Amnistia2017 : IAministia
    {
        public decimal ObtenerValorDescuento(Cuenta cuenta)
        {
            return cuenta.SaldoDeuda * 0.20m;
        }
    }
}
