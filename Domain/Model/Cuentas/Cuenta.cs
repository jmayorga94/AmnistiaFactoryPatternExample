using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Cuentas
{
    public class Cuenta
    {
        public int TipoCuenta { get; set; }
        public int TipoImpuesto { get; set; }
        public decimal SaldoDeuda { get; set; }
    }
}
