
namespace com.aluno.veiculos.entidades.carros
{
    public class Caminhonete : Carro
    {
        private int capacidadeCarga;

        public Caminhonete(string marca, string modelo, int ano, int numeroPortas, int capacidadeCarga)
            : base(marca, modelo, ano, numeroPortas)
        {
            this.capacidadeCarga = capacidadeCarga;
        }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine($"Caminhonete com capacidade de carga: {capacidadeCarga} kg");
        }
    }
}
