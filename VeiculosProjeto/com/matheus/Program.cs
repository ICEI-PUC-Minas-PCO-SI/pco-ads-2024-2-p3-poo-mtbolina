
using System;
using com.aluno.veiculos.entidades;
using com.aluno.veiculos.entidades.carros;
using com.aluno.veiculos.entidades.motos;

class Program
{
    static void Main(string[] args)
    {
        
        Veiculo carro1 = new Carro("Fusca", "Volkswagen", 1976, 2);
        Veiculo carro2 = new Carro("Civic", "Honda", 2020, 4);
        Veiculo sedan1 = new Sedan("Camry", "Toyota", 2021, 4, true);
        Veiculo sedan2 = new Sedan("A4", "Audi", 2022, 4, false);
        Veiculo caminhonete1 = new Caminhonete("Hilux", "Toyota", 2023, 4, 1000);
        Veiculo caminhonete2 = new Caminhonete("Ranger", "Ford", 2022, 4, 1200);

        Veiculo moto1 = new Moto("Ninja", "Kawasaki", 2020, false);
        Veiculo moto2 = new Moto("Ducati", "Monster", 2021, true);
        Veiculo motoEsportiva1 = new MotoEsportiva("Yamaha", "YZF-R1", 2022, false, 200);
        Veiculo motoCruiser1 = new MotoCruiser("Harley-Davidson", "Fat Boy", 2021, true, "Wide");

        
        carro1.mostrar();
        carro2.mostrar();
        sedan1.mostrar();
        sedan2.mostrar();
        caminhonete1.mostrar();
        caminhonete2.mostrar();
        moto1.mostrar();
        moto2.mostrar();
        motoEsportiva1.mostrar();
        motoCruiser1.mostrar();

        
        Seguro seguroCarro1 = (Seguro)carro1;
        seguroCarro1.seguroParticular();
        
        Seguro seguroSedan1 = (Seguro)sedan1;
        seguroSedan1.seguroParticular();
        
        Seguro seguroCaminhonete1 = (Seguro)caminhonete1;
        seguroCaminhonete1.seguroParticular();
    }
}
