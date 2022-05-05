using System;
namespace CadastroCliente
{
    public class Cliente
    {
        public string Nome { get; set; }
        public long CPF { get; set; }
        public DateTime Dt_nascimento { get; set; }
        public float Renda_mensal { get; set; }
        public char Estado_civil { get; set; }
        public int Dependentes { get; set; }

        public Cliente()
        {
        }
    }
}
