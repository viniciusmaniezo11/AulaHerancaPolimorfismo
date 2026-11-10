namespace Heranca
{
    public class Gerente : Funcionario //* Está herdando a classe funcionario
    {
        public int Codigo { get; set; }

        public Gerente(){}
        public Gerente(string nome, decimal salario, int codigo) : base(nome, salario)
        {
            //* Quando houver um construtor na classe base é necessario criar um nas classes filhas também.
            //* a filha pode possuir algo a mais doque a classe pai.
            Codigo = codigo;
        } 

        public void GerenciarEquipe()
        {
            Console.WriteLine("Gestor está gerenciando a equipe.");
        }

        public void ExibirSalario()
        {
            Console.WriteLine($"Salario: {Salario:C}");
        }

        public void DefinirSalario(decimal valor)
        {
            Salario = valor;
        }

        public override void Trabalhar() //* override -> Substitui um metodo do Funcionario() apontado pelo virtual
        {
            Console.WriteLine("Gerente está trabalhando.");
        }

        public override decimal CalcularBonus() 
        {
            return 1000m;
        }
    }
}   



