namespace Heranca
{
    public class PagamentoPix : IPagamento //* Tudo que estiver contido na interface precisa estar na classe que a herda, mais doque o minimo não afeta.
    {
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"O pagamento via pix no valor de {valor:C} foi efetuado.");
        }
    }
}