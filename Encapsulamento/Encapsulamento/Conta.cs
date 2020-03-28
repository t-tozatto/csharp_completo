using System.Globalization;

namespace Exercicio_Banco_Secao_5
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int conta, string titular)
        {
            NumeroConta = conta;
            Titular = titular;
        }

        public Conta(int conta, string titular, double depositoInicial) : this(conta, titular)
        {
            Deposito(depositoInicial);
        }

        public override string ToString()
        {
            return string.Concat("Conta ", NumeroConta, ", Titular: ", Titular, ", Saldo: $ ", Saldo.ToString("N2"), CultureInfo.InvariantCulture);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }
    }
}
