// //using BoletoNetCore; // https://github.com/BoletoNet/boletonet
// // using BoletoNet; //https://github.com/BoletoNet/boletonet
// using System.Web;
// namespace ConsoleApp;
// public abstract class Pagamento
// {

//     float valor = 0;

//     bool parcelado = false;

//     short numeroParcela = 0;

//     public virtual void Pagar()
//     {
//         Console.WriteLine("Dentro classe abstrata Pagamento, algo de errado");
//     }

// }
// class PagamentoBoleto : Pagamento
// {

//     public override void Pagar()
//     {
//         //  Console.WriteLine("Dentro classe PagamentoBoleto");

//         var cedente = new Cedente("123456789", "Empresa Lander", "1234", "56789");
//         var sacado = new Sacado("99999999999", "Cliente XYZ");
//         var enderecoSacado = new Endereco
//         {
//             End = "Rua do Cliente, 123",
//             Bairro = "Bairro do Cliente",
//             Cidade = "Cidade",
//             CEP = "12345-678",
//             UF = "UF"
//         };
//         sacado.Endereco = enderecoSacado;

//         var boleto = new Boleto(DateTime.Now.AddDays(7), 100.00m, "12", "34567890", cedente);
//         boleto.Sacado = sacado;
//         boleto.EspecieDocumento = new EspecieDocumento_Bradesco("17");

//         var boletoBancario = new BoletoBancario
//         {
//             CodigoBanco = 237,
//             Boleto = boleto
//         };

//         Console.WriteLine(boletoBancario.MontaHtml());
//     }
// }
