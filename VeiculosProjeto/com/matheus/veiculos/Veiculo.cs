
namespace com.aluno.veiculos.entidades
{
    public class Veiculo
    {
        private string marca;
        private string modelo;
        private int ano;

        public Veiculo(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }

        public virtual void mostrar()
        {
            Console.WriteLine($"Veículo: {marca} {modelo}, Ano: {ano}");
        }
    }
}
