using OC_Calculus_ConsoleClient.OperationsArithmetiquesService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_Calculus_ConsoleClient
{
    class Program
    {
        public static double Infinity { get; private set; }
        public static double NaN { get; private set; }

        static void Main(string[] args)
        {

            // var clientOperationsArithmetiquesService = new ();
            OperationsArithmetiquesClient client = new OperationsArithmetiquesClient();

            //Les operations +, -, * et /
            Console.WriteLine(" ------------ Les operations +, , * et / ------------ ");

            Console.WriteLine($"42.514 + 13.967 = {client.Plus(42.514d, 13.967d)} \ndoit renvoyer 56.481");

            Console.WriteLine($"42.514 + 13.967 = {client.Moins(42.514d, 13.967d)} \ndoit renvoyer 28.547");

            Console.WriteLine($"4.5 * 11.5 = {client.Multiplier(4.5d, 11.5d)} \ndoit renvoyer 51.75");

            string infinity = "Infinity";
            Console.WriteLine($"51.75/11.5 = {client.Diviser(51.75d, 11.5d)} \ndoit renvoyer 4.5");
            Console.WriteLine(
                $"51.75/0 = " +
                $"{((client.Diviser(51.75d, 0) == client.Diviser(51.75d, 0) + 100) ? infinity : client.Diviser(51.75d, 0).ToString())} " +
                $"//doit renvoyer {infinity} "
                );

            //Est Multiple De
            Console.WriteLine("\n ------------ Est Multiple De ------------ ");

            Console.WriteLine($"45 est multiple de 5 : {client.EstMultipleDe(45, 5)} \ndoit renvoyer true");

            Console.WriteLine($"60 est multiple de 13 : {client.EstMultipleDe(60, 13)} \ndoit renvoyer false");
            //Additions Entieres
            Console.WriteLine("\n ------------ Additions Entieres ------------ ");
            String chaine = "68 + 14 + 7 + 29";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEntieres(chaine)} \ndoit renvoyer 118");
            chaine = "48";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEntieres(chaine)} \ndoit renvoyer 48");
            chaine = "";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEntieres(chaine)} \ndoit renvoyer 0");

            //Additions Reelles
            Console.WriteLine("\n ------------ Additions Reelles ------------ ");
            chaine = "68,48+14,21+7,8+2,63";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsReelles(chaine)} \ndoit renvoyer 93,12");
            chaine = "48,12";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsReelles(chaine)} \ndoit renvoyer 48.12");
            chaine = "48.12";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsReelles(chaine)} \ndoit renvoyer 48.12");
            chaine = "";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsReelles(chaine)} \ndoit renvoyer 0");



            //Additions Et De Soustractions Entieres
            Console.WriteLine("\n ------------ Additions Et De Soustractions Entieres ------------ ");
            chaine = "-18+65-14+78";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEtDeSoustractionsEntieres(chaine)} \ndoit renvoyer 111");
            chaine = "208+66+14";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEtDeSoustractionsEntieres(chaine)} \ndoit renvoyer 288");
            chaine = "";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEtDeSoustractionsEntieres(chaine)} \ndoit renvoyer 0");



            //Additions Et De Soustractions Reelles
            Console.WriteLine("\n ------------ Additions Et De Soustractions Entieres ------------ ");
            chaine = "-18,48+65,44-14,484+78,221";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEtDeSoustractionsReelles(chaine)} \ndoit renvoyer 110,697");
            chaine = "208.48315184";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEtDeSoustractionsReelles(chaine)} \ndoit renvoyer 208,48315184");
            chaine = "208,48315184";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEtDeSoustractionsReelles(chaine)} \ndoit renvoyer 208,48315184");
            chaine = "";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEtDeSoustractionsReelles(chaine)} \ndoit renvoyer 0");




            //Additions Et Soustractions Et Multiplications Entieres
            Console.WriteLine("\n ------------ Additions Et Soustractions Et Multiplications Entieres ------------ ");
            chaine = "-69*18+14-22*-75";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEtSoustractionsEtMultiplicationsEntieres(chaine)} \ndoit renvoyer 422");
            chaine = "208*66*14-48*52";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEtSoustractionsEtMultiplicationsEntieres(chaine)} \ndoit renvoyer 189696");
            chaine = "";
            Console.WriteLine($" {chaine} = {client.ChaineDAdditionsEtSoustractionsEtMultiplicationsEntieres(chaine)} \ndoit renvoyer 0");

            client.Close();

            Console.ReadLine();
        }
    }
}
