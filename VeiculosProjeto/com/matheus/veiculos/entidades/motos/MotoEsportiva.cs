
namespace com.aluno.veiculos.entidades.motos
{
    public class MotoEsportiva : Moto
    {
        private int potencia;

        public MotoEsportiva(string marca, string modelo, int ano, bool temCarona, int potencia)
            : base(marca, modelo, ano, temCarona)
        {
            this.potencia = potencia;
        }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine($"Moto esportiva com potência: {potencia} cv");
        }
    }
}
