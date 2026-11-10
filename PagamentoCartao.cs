namespace Heranca
{
    public class PagamentoCartao : IPagamento //* A interface serve um proposito mais geral doque as classes e metodos abstratos.
    {
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"O pagamento via cartão no valor {valor:C} foi efetuado.");
        }
    }
}