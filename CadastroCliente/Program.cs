using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CadastroCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            bool entradaValida = false;
            Console.WriteLine("Favor informar os dados abaixo: ");
            while (!entradaValida)
            {
                Console.Write("Nome: ");
                string inputNome = Console.ReadLine();
                if (validaNome(inputNome))
                {
                    entradaValida = true;
                    cliente.Nome = inputNome.Trim();
                }
                else
                {
                    Console.WriteLine("O nome deve conter pelo menos 5 caracteres. Favor digite um nome válido");
                }
            }

            entradaValida = false;
            while (!entradaValida)
            {
                Console.Write("CPF: ");
                string inputCPF = Console.ReadLine();
                if (validaCPF(inputCPF))
                {
                    cliente.CPF = long.Parse(inputCPF.Replace(".", "").Replace("-", ""));
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("O CPF deve conter exatamente 11 digitos. Favor digite um CPF válido");
                }
            }

            entradaValida = false;
            DateTime data;
            while (!entradaValida)
            {
                Console.Write("Data de nascimento: ");
                string inputData = Console.ReadLine();
                if (validaData(out data, inputData) && maiorIdade(data))
                {
                    cliente.Dt_nascimento = data;
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("A data deve estar no formato DD/MM/AAAA e ser maior de 18 anos. Favor digite uma data válida");
                }
            }

            entradaValida = false;
            float renda;
            while (!entradaValida)
            {
                Console.Write("Renda mensal: R$");
                string inputRendaMensal = Console.ReadLine();
                if (validaRenda(out renda, inputRendaMensal) && inputRendaMensal.Contains(","))
                {
                    cliente.Renda_mensal = renda;
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("A renda mensal deve ser informada com 2 casas decimais e virgula");
                }
            }

            entradaValida = false;
            while (!entradaValida)
            {
                Console.Write("Estado Civil: ");
                string inputEstadoCivil = Console.ReadLine();
                if (validaEstadoCivil(inputEstadoCivil))
                {
                    cliente.Estado_civil = inputEstadoCivil.ToUpper().ToCharArray()[0];
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Favor informe o seu estado civil como C ou c, S ou s, V ou v, D ou d");
                }
            }

            entradaValida = false;
            int dependentes;
            while (!entradaValida)
            {
                Console.Write("Numero de dependentes: ");
                string inputDependentes = Console.ReadLine();
                if (Int32.TryParse(inputDependentes, out dependentes) &&
                    (dependentes >=0 && dependentes <= 10)) 
                {
                    cliente.Dependentes = dependentes;
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("O número de dependentes deve ser entra 0 e 10. Tente novamente.");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"CPF: {cliente.CPF}");
            Console.WriteLine($"Data de nascimento: {cliente.Dt_nascimento}");
            Console.WriteLine($"Renda mensal: R${cliente.Renda_mensal}");
            Console.WriteLine($"Estado Civil: {cliente.Estado_civil}");
            Console.WriteLine($"Número de dependentes: {cliente.Dependentes}");
        }

        private static bool validaRenda(out float renda, string inputRendaMensal)
        {
            var culture = CultureInfo.GetCultureInfo("fr-FR");
            return float.TryParse(inputRendaMensal, NumberStyles.Currency, culture, out renda);
        }

        private static bool validaData(out DateTime data, string inputData)
        {
            return DateTime.TryParseExact(inputData,
                                                       "dd/MM/yyyy",
                                                       CultureInfo.InvariantCulture,
                                                       DateTimeStyles.None, out data);
        }

        private static bool validaNome(string nome)
        {
            string padrao = "^([a-zA-Z ]*?)\\s*([a-zA-Z]*)$";
            return Regex.IsMatch(nome, padrao) && (nome.Length > 4);
        }

        private static bool validaCPF(string cpf)
        {
            string padrao = "[0-9]{3}.?[0-9]{3}.?[0-9]{3}-?[0-9]{2}";
            return Regex.IsMatch(cpf, padrao);
        }

        private static bool maiorIdade(DateTime data_nascimento)
        {
            var hoje = DateTime.Today;
            return (hoje.Year - data_nascimento.Year >= 18);
        }

        private static bool validaEstadoCivil(string estado_civil)
        {
            return (estado_civil.ToUpper() == "C" ||
                estado_civil.ToUpper() == "S" ||
                estado_civil.ToUpper() == "V" ||
                estado_civil.ToUpper() == "D");           
        }
        
    }
}
