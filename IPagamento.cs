namespace Heranca
{
    public interface IPagamento //* Serve de herança para uma outra classe
    {
        void Pagar(decimal valor);
        // void Receber(decimal valor);
        // void Emprestar();
    }
}