
namespace com.aluno.veiculos.entidades.motos
{
    public class Moto : Veiculo
    {
        private bool temCarona;

        public Moto(string marca, string modelo, int ano, bool temCarona)
            : base(marca, modelo, ano)
        {
            this.temCarona = temCarona;
        }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine($"Moto com carona: {temCarona}");
        }
    }
}
