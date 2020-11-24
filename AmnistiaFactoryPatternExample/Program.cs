using Domain.Model.Cuentas;
using Domain.Model.Cuentas.Managers;
using System;

namespace AmnistiaFactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta()
            {
                SaldoDeuda = 200,
                TipoCuenta = 1,
                TipoImpuesto = 105
            };

            Cuenta cuentaConDeudaMayor = new Cuenta()
            {
                SaldoDeuda = 200,
                TipoCuenta = 2,
                TipoImpuesto = 201
            };

            CuentaManager manager = new CuentaManager();

          
            Console.WriteLine($"Aplicar Amnistia utilizando el patron de diseño factory");

            Console.WriteLine($"Saldo Deuda:{cuenta.SaldoDeuda}");
            Console.WriteLine($"Tipo Cuenta :{cuenta.TipoCuenta}");
            Console.WriteLine($"Tipo Impuesto: {cuenta.TipoImpuesto}");

            Console.WriteLine($"***APLICANDO AMNISTIA *******");

            manager.AplicarAmnistia(cuenta);

            Console.WriteLine($"Nuevo saldo Deuda {cuenta.SaldoDeuda}");
            Console.ReadLine();


            Console.WriteLine($"Saldo Deuda:{cuentaConDeudaMayor.SaldoDeuda}");
            Console.WriteLine($"Tipo Cuenta :{cuentaConDeudaMayor.TipoCuenta}");
            Console.WriteLine($"Tipo Impuesto: {cuentaConDeudaMayor.TipoImpuesto}");

            Console.WriteLine($"***APLICANDO AMNISTIA *******");

            manager.AplicarAmnistia(cuentaConDeudaMayor);

            Console.WriteLine($"Nuevo saldo Deuda {cuentaConDeudaMayor.SaldoDeuda}");
            Console.ReadLine();

        }
    }
}
