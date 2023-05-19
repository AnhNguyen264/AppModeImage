using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModeImage
{
    public class ModeImage
    {
        /// <summary>
        /// Represente l'application: 
        /// </summary>
        #region CONSTANTES
        // obtient ou definite les valeurs

        public const int DÉFAUT_LUMINOSITÉ = 75;
        public const int DÉFAUT_CONTRASTE = 65;
        public const int DÉFAUT_COULEUR = 50;
        public const int DÉFAUT_TEINTE = 0;
        public const int DÉFAUT_NETTETÉ = 5;


        private int m_contraste;
        private int m_couleur;
        private int m_luminosité;
        private int m_netteté;
        private int m_teinte;
        #endregion

        #region PROPRIETES
        // obtient ou modifie constraste
        public int Contraste
        {
            get { return m_contraste; }
            set
            {
                m_contraste = ValiderValeur(0, 100, value);
            }
            }

        // obtient ou modifie couleur
        public int Couleur
        {
            get { return m_couleur; }
            set
            {
                m_couleur = ValiderValeur(0, 100, value);
            }
        }

        // obtient ou modifier luminosite
        public int Luminosité
        {
            get { return m_luminosité; } 
           set {
                m_luminosité = ValiderValeur(0, 100, value);
                }
            
        }
        // obtient ou modifie nettete
        public int Netteté
        {
            get { return m_netteté; } 
            set
            {
                m_netteté = ValiderValeur(0,10,value);
            }
        }
        // obtient ou modifie la teinte 
        public int Teinte
        {
            get { return m_teinte; }// retourne la valeur de teinte 
            set
            {
                m_teinte = ValiderValeur(-10, 10, value);// modifie
            }
        }

        public string Nom //auto ou calcul
        {
            get;
           
        }
        #endregion
        #region METHODES

       
        /// <summary>
        /// constructeur instancie un objets de type téléviseur 
        /// </summary>
        /// <param name="pNom"> donne un nom</param>
        public ModeImage(string pNom)
        {

                    Nom = pNom;
                    Luminosité = DÉFAUT_LUMINOSITÉ;
                    Contraste = DÉFAUT_CONTRASTE;
                    Couleur = DÉFAUT_COULEUR;
                    Teinte = DÉFAUT_TEINTE;
                    Netteté = DÉFAUT_NETTETÉ;
                }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pNom"></param>
        /// <param name="pLuminosité"></param>
        /// <param name="pContraste"></param>
        /// <param name="pCouleur"></param>
        /// <param name="pTeinte"></param>
        /// <param name="pNetteté"></param>
      public ModeImage(string pNom, int pLuminosité, int pContraste, int pCouleur, int pTeinte, int pNetteté)
        {
            Nom = pNom;
          
            Luminosité = pLuminosité;
          
            Contraste = pContraste;
           
            Couleur = pCouleur;
            
            Teinte = pTeinte;
        
            Netteté = pNetteté;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pMin"></param>
        /// <param name="pMax"></param>
        /// <param name="pValeur"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private int ValiderValeur(int pMin, int pMax, int pValeur)
        {
            if (pValeur < pMin || pValeur > pMax)
                throw new ArgumentOutOfRangeException();
            else
                return pValeur;


        }
        }
    #endregion
}
