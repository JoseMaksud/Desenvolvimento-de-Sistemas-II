using System;
using System.Linq;

public class Program
{
    public static void PerguntarSenha() {
        Console.WriteLine("Digite sua Senha: ");
    }

    public static void Main(string[] args)
    {
        // Sofware de validação de senha
        PerguntarSenha();
        string senha = Console.ReadLine();

        // Confirmar Senha
        Console.WriteLine("Confirme sua senha: ");
        string confirmarSenha = Console.ReadLine();

        // Faz a validação
        bool tamanhoValido = senha.Length >= 8;
        bool contemNumero = senha.Any(char.IsDigit);
        bool contemMaiuscula = senha.Any(char.IsUpper);

        // Faz a validação da confirmação
        bool tamanhoValido2 = confirmarSenha.Length >= 8;
        bool contemNumero2 = confirmarSenha.Any(char.IsDigit);
        bool contemMaiuscula2 = confirmarSenha.Any(char.IsUpper);


        // Testa se todos foram positivos
        if (tamanhoValido && contemMaiuscula && contemNumero) {
            Console.WriteLine("Senha Válida!");
        } else {
            Console.WriteLine("Senha Inválida!");
        }

        // Testa se todos foram positivos
        if (tamanhoValido2 && contemMaiuscula2 && contemNumero2) {
            Console.WriteLine("Confirmação de Senha Válida!");
        } else {
            Console.WriteLine("Confirmação de Senha Inválida!");
        }

        // Testa se as senhas conferem
        if (senha == confirmarSenha) {
            Console.WriteLine("Senhas conferem!");
        } else {
            Console.WriteLine("Senhas não conferem!");
        }
    }
}