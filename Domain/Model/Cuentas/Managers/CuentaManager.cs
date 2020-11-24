using Domain.Model.Amnistias;
using Domain.Model.Amnistias.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Cuentas.Managers
{
    public class CuentaManager
    {
        public void AplicarAmnistia(Cuenta cuenta)
        {
           
             IAministia amnistiaAplicar = AmnistiaFactory.AplicarAmnistia(cuenta);

             var valorAmnistia = amnistiaAplicar.ObtenerValorDescuento(cuenta);

            Console.WriteLine($"Amnistia tipo {amnistiaAplicar.GetType()}");

            cuenta.SaldoDeuda = cuenta.SaldoDeuda - valorAmnistia;
        }
    }
}
