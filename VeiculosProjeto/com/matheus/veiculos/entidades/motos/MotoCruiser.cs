
namespace com.aluno.veiculos.entidades.motos
{
    public class MotoCruiser : Moto
    {
        private string tipoGuidão;

        public MotoCruiser(string marca, string modelo, int ano, bool temCarona, string tipoGuidão)
            : base(marca, modelo, ano, temCarona)
        {
            this.tipoGuidão = tipoGuidão;
        }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine($"Moto cruiser com tipo de guidão: {tipoGuidão}");
        }
    }
}
