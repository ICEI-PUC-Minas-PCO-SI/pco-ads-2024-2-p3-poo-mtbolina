
namespace com.aluno.veiculos.entidades.carros
{
    using com.aluno.veiculos.entidades.servicos;

    public class Carro : Veiculo, Seguro
    {
        private int numeroPortas;

        public Carro(string marca, string modelo, int ano, int numeroPortas)
            : base(marca, modelo, ano)
        {
            this.numeroPortas = numeroPortas;
        }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine($"Número de portas: {numeroPortas}");
        }

        public void seguroParticular()
        {
            Console.WriteLine("Seguro particular do carro ativo.");
        }
    }
}
