
namespace com.aluno.veiculos.entidades.carros
{
    public class Sedan : Carro
    {
        private bool temPortaMalas;

        public Sedan(string marca, string modelo, int ano, int numeroPortas, bool temPortaMalas)
            : base(marca, modelo, ano, numeroPortas)
        {
            this.temPortaMalas = temPortaMalas;
        }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine($"Sedan com porta-malas: {temPortaMalas}");
        }
    }
}
