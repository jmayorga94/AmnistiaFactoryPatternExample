using Domain.Model.Cuentas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Amnistias.Factories
{
    public static class AmnistiaFactory
    {
        public static IAministia AplicarAmnistia(Cuenta cuenta)
        {
            if (cuenta.TipoCuenta == 1 && cuenta.SaldoDeuda > 100)
            {
                
                return new Amnistia2017();
            }
            else
            {
                return new AmnistiaCovid();
            }
        }
    }
}
