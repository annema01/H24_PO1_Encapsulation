using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage //remplace internal par oublic pour sauver du temps  //internal veut dire visible dans le même projet
    {
        string nom;
        int pointsDeVie;
        int pointsDePuissance;

        //select les attributs, clic droit, Action rapide ... (premier) > encapsuler...(propriété)
        // le propriété automatiquement nommé comme les attributs avec mais avec une lettre majuscule
        public string Nom { get => nom; set => nom = value; } //si on supprime le set, la propriété sera en lecture seule
        public int PointsDeVie
        {
            get => pointsDeVie;
            set
            {
                if (value < 0)
                {
                    pointsDeVie = 0; //l'attribut ici
                }
                else
                {
                    pointsDeVie = value;
                }
            }
        }
        public int PointsDePuissance { get => pointsDePuissance; set => pointsDePuissance = value; }

        public bool EstEnVie //dans la forme, on aurrait acces a faire une if (personnage.EstEnVie) "Vous êtes pas mort" par exemple
        {
            get
            {
                if (pointsDeVie > 0)
                {
                    return true;
                }
                return false;
            }
        }

    }
}
