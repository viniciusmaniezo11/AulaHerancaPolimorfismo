namespace Heranca
{
    public abstract class Funcionario //* abstract -> Faz com que ela não possa ser instanciada
    {
        public string? Nome { get; set; }
        protected decimal Salario { get; set; }

        public virtual void Trabalhar() //* virtual -> Aponta que é o alvo do override do Gerente()
        {   
            Console.WriteLine("Fucionario está trabalhando.");
        }

        public abstract decimal CalcularBonus();

        public Funcionario(){}
        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }
    }
}