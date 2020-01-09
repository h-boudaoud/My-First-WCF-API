using System;
using System.Collections.Generic;
using System.Linq;

namespace OC_Calculus_WCFService
{
    public class OperationsArithmetiques : IOperationsArithmetiques
    {
        public double Plus(double nb1, double nb2)
        {
            //TODO
            return nb1 + nb2;
        }

        public double Moins(double nb1, double nb2)
        {
            //TODO
            return nb1 - nb2;
        }

        public double Diviser(double nb1, double nb2)
        {
            //TODO
            return nb1 / nb2;
        }

        public double Multiplier(double nb1, double nb2)
        {
            //TODO
            return nb1 * nb2;
        }

        public bool EstMultipleDe(int nb1, int nb2)
        {
            //TODO
            return (nb1 % nb2 == 0);
        }

        public int ChaineDAdditionsEntieres(string chaine)
        {
            //TODO

            return Convert.ToInt32(ChaineDAdditionsReelles(chaine));
        }

        public double ChaineDAdditionsReelles(string chaine)
        {
            //TODO
            double sum = 0;
            if (chaine != null && chaine != "")
            {
                //double r1 = Convert.ToDouble("3.2");
                double r = Convert.ToDouble("3,2");
                chaine = chaine.Replace('.', ',');
                List<string> chaine_nb = chaine.Split('+').ToList();
                foreach (string item in chaine_nb)
                {
                    double value = (item=="") ?0:Convert.ToDouble(item);
                    sum += value;
                }
            }

            //TODO
            return sum;
        }
        public int ChaineDAdditionsEtDeSoustractionsEntieres(string chaine)
        {
            //TODO

            return Convert.ToInt32(ChaineDAdditionsEtDeSoustractionsReelles(chaine));
        }
        public double ChaineDAdditionsEtDeSoustractionsReelles(string chaine)
        {
            //TODO
            if (chaine != null && chaine != "")
            {

                chaine = chaine.Replace(".", ",").Replace("-+", "-").Replace("+-", "-").Replace("--", "+");
                chaine = chaine.Replace("-", "+-");
                return ChaineDAdditionsReelles(chaine);

                //// Une autre methode

                //List<string> list_ChaineAddition = ("0" + chaine).Split('-').ToList();
                //double resultat = ChaineDAdditionsReelles(list_ChaineAddition[0]);
                //list_ChaineAddition.Remove(list_ChaineAddition[0]);
                //foreach (string item in list_ChaineAddition)
                //{
                //    resultat += ChaineDAdditionsReelles("-" + item);
                //}

                //return resultat;
            }
            return 0;
        }
        public int ChaineDAdditionsEtSoustractionsEtMultiplicationsEntieres(string chaine)
        {
            //TODO
            int resultat = 0;
            if (chaine != null && chaine != "")
            {

                chaine = chaine.Replace("-+", "-").Replace("+-", "-").Replace("--", "+").Replace("*-", "¤");
                chaine = chaine.Replace("-", "+-");
                //list_ChaineSoustracion.Remove(list_ChaineSoustracion[0]);
                List<string> list_ChaineAddition = chaine.Split('+').ToList();
                foreach (string itemAddition in list_ChaineAddition)
                {
                    string item = (itemAddition.Contains("¤")) ? itemAddition.Replace("¤", "*-") : itemAddition;

                    if (item.Contains("*") )
                    {
                        List<string> list_ChaineProduit = item.Split('*').ToList();
                        int produit = 1;
                        foreach (string itemProduit in list_ChaineProduit)
                        {
                            produit *= Convert.ToInt32(itemProduit);
                        }

                        resultat += produit;
                    }
                    else
                    {
                        resultat += ((item == "") ? 0 : Convert.ToInt32(item));
                    }
                }
            }
            return resultat;
        }
    }
}
