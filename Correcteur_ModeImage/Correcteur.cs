// Pour "activer" un groupe de tests, enlever le commentaire en avant du #define
#define TestsClasseModeImage
#define TestsFormulaire

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using AppModeImage;

namespace AppModeImage
{
    [TestClass]
    public class Correcteur 
    {
        public static string m_version = "Correcteur H23.1.2";


        #region Attributs de tests supplémentaires

        #region Variables et propriétés
        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        #endregion

        private static int m_totalScore;
        private static int m_maxScore;

        //ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            m_totalScore = 0;
            m_maxScore = 0;
        }
        //
        //ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            StreamWriter ficScore = new StreamWriter("../../../Score.txt");
            ficScore.Write("AppModeImage" + "\n");
            ficScore.Write(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            ficScore.Write("\nRésultat de la correction\n\nScore : " + m_totalScore + "/" + m_maxScore, Correcteur.m_version, MessageBoxButtons.OK, MessageBoxIcon.Information);
            ficScore.Close();
        }

        #endregion

        #region Tests de la classe ModeImage
#if TestsClasseModeImage
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 1 paramètre de la classe ModeImage
        /// Test également les accesseurs en lecture des propriétés
        ///</summary>
        [TestMethod()]
        public void T01_MI_Constructeur1Param()
        {
            m_maxScore += 5;

            string nom = "XYZ";
            ModeImage target = new ModeImage(nom);
            Assert.AreEqual("XYZ", target.Nom);
            Assert.AreEqual(ModeImage.DÉFAUT_LUMINOSITÉ, target.Luminosité);
            Assert.AreEqual(ModeImage.DÉFAUT_CONTRASTE, target.Contraste);
            Assert.AreEqual(ModeImage.DÉFAUT_COULEUR, target.Couleur);
            Assert.AreEqual(ModeImage.DÉFAUT_TEINTE, target.Teinte);
            Assert.AreEqual(ModeImage.DÉFAUT_NETTETÉ, target.Netteté);
            m_totalScore += 5;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 6 paramètres de la classe ModeImage avec des valeurs valides
        /// Test également les accesseurs en lecture des propriétés
        ///</summary>
        [TestMethod()]
        public void T02_MI_Constructeur6Params()
        {
            m_maxScore += 10;

            ModeImage target = new ModeImage("XYZ",98,99,100,9,10);
            Assert.AreEqual("XYZ", target.Nom);
            Assert.AreEqual(98, target.Luminosité);
            Assert.AreEqual(99, target.Contraste);
            Assert.AreEqual(100, target.Couleur);
            Assert.AreEqual(9, target.Teinte);
            Assert.AreEqual(10, target.Netteté);
            m_totalScore += 2;


            target = new ModeImage("ABC", 100,0,1,10,0);
            Assert.AreEqual("ABC", target.Nom);
            Assert.AreEqual(100, target.Luminosité);
            Assert.AreEqual(0, target.Contraste);
            Assert.AreEqual(1, target.Couleur);
            Assert.AreEqual(10, target.Teinte);
            Assert.AreEqual(0, target.Netteté);
            m_totalScore += 2;

            target = new ModeImage("PCX", 0, 1, 2, -10, 5);
            Assert.AreEqual("PCX", target.Nom);
            Assert.AreEqual(0, target.Luminosité);
            Assert.AreEqual(1, target.Contraste);
            Assert.AreEqual(2, target.Couleur);
            Assert.AreEqual(-10, target.Teinte);
            Assert.AreEqual(5, target.Netteté);
            m_totalScore += 2;

            target = new ModeImage("ZQXD", 1, 100, 0, 0, 7);
            Assert.AreEqual("ZQXD", target.Nom);
            Assert.AreEqual(1, target.Luminosité);
            Assert.AreEqual(100, target.Contraste);
            Assert.AreEqual(0, target.Couleur);
            Assert.AreEqual(0, target.Teinte);
            Assert.AreEqual(7, target.Netteté);
            m_totalScore += 2;

            target = new ModeImage("allo", ModeImage.DÉFAUT_LUMINOSITÉ, ModeImage.DÉFAUT_CONTRASTE, ModeImage.DÉFAUT_COULEUR, ModeImage.DÉFAUT_TEINTE, ModeImage.DÉFAUT_NETTETÉ);
            Assert.AreEqual("allo", target.Nom);
            Assert.AreEqual(ModeImage.DÉFAUT_LUMINOSITÉ, target.Luminosité);
            Assert.AreEqual(ModeImage.DÉFAUT_CONTRASTE, target.Contraste);
            Assert.AreEqual(ModeImage.DÉFAUT_COULEUR, target.Couleur);
            Assert.AreEqual(ModeImage.DÉFAUT_TEINTE, target.Teinte);
            Assert.AreEqual(ModeImage.DÉFAUT_NETTETÉ, target.Netteté);
            m_totalScore += 2;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 6 paramètres de la classe ModeImage avec des valeurs non valides
        ///</summary>
        [TestMethod()]
        public void T03_MI_Const6ParamsLimitesLuminosité()
        {
            m_maxScore += 2;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", -1, 0, 0, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 101, 0, 0, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 2) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 6 paramètres de la classe ModeImage avec des valeurs non valides
        ///</summary>
        [TestMethod()]
        public void T04_MI_Const6ParamsLimitesContraste()
        {
            m_maxScore += 2;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, -1, 0, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 101, 0, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 2) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 6 paramètres de la classe ModeImage avec des valeurs non valides
        ///</summary>
        [TestMethod()]
        public void T05_MI_Const6ParamsLimitesCouleur()
        {
            m_maxScore += 2;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, 0, -1, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 101, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 2) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 6 paramètres de la classe ModeImage avec des valeurs non valides
        ///</summary>
        [TestMethod()]
        public void T06_MI_Const6ParamsLimitesTeinte()
        {
            m_maxScore += 2;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, -11, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 11, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 2) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 6 paramètres de la classe ModeImage avec des valeurs non valides
        ///</summary>
        [TestMethod()]
        public void T07_MI_Const6ParamsLimitesNetteté()
        {
            m_maxScore += 2;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, -1);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, 11);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 2) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test des valeurs limites pour l'accesseur en écriture de la propriété Luminosité
        ///</summary>
        [TestMethod()]
        public void T08_MI_LuminositéÉcritureLimites()
        {
            m_maxScore += 2;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, 0);
                target.Luminosité = -1;
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, 0);
                target.Luminosité = 101;
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 2) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test des valeurs limites pour l'accesseur en écriture de la propriété Contraste
        ///</summary>
        [TestMethod()]
        public void T09_MI_ContrasteÉcritureLimites()
        {
            m_maxScore += 2;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, 0);
                target.Contraste = -1;
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, 0);
                target.Contraste = 101;
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 2) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test des valeurs limites pour l'accesseur en écriture de la propriété Couleur
        ///</summary>
        [TestMethod()]
        public void T10_MI_CouleurÉcritureLimites()
        {
            m_maxScore += 2;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, 0);
                target.Couleur = -1;
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, 0);
                target.Couleur = 101;
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 2) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test des valeurs limites pour l'accesseur en écriture de la propriété Teinte
        ///</summary>
        [TestMethod()]
        public void T11_MI_TeinteÉcritureLimites()
        {
            m_maxScore += 2;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, 0);
                target.Teinte = -11;
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, 0);
                target.Teinte = 11;
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 2) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test des valeurs limites pour l'accesseur en écriture de la propriété Netteté
        ///</summary>
        [TestMethod()]
        public void T12_MI_NettetéÉcritureLimites()
        {
            m_maxScore += 2;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, 0);
                target.Netteté = -1;
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, 0);
                target.Netteté = 11;
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 2) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
#endif
        #endregion

        #region Tests du formulaire principal
#if TestsFormulaire
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste l'état initial du formulaire principal
        ///</summary>
        [TestMethod()]
        public void T13_Frm_ÉtatInitial()
        {
            m_maxScore += 2;
            FrmPrincipal target = new FrmPrincipal();

            Assert.AreEqual("Sport", target.lblNomModeImage.Text);
            Assert.AreEqual(90, target.vsiLuminosité.Value);
            Assert.AreEqual(60, target.vsiContraste.Value);
            Assert.AreEqual(50, target.vsiCouleur.Value);
            Assert.AreEqual(0, target.vsiTeinte.Value);
            Assert.AreEqual(6, target.vsiNetteté.Value);

            m_totalScore += 2;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste le passage au deuxième mode image 
        ///</summary>
        [TestMethod()]
        public void T14_Frm_PasserAuDeuxièmeMode()
        {
            m_maxScore += 2;

            FrmPrincipal target = new FrmPrincipal();

            target.BtnModeImageSuivant_Click(target, EventArgs.Empty);
            Assert.AreEqual("Jeu", target.lblNomModeImage.Text);
            Assert.AreEqual(100, target.vsiLuminosité.Value);
            Assert.AreEqual(70, target.vsiContraste.Value);
            Assert.AreEqual(52, target.vsiCouleur.Value);
            Assert.AreEqual(1, target.vsiTeinte.Value);
            Assert.AreEqual(4, target.vsiNetteté.Value);


            m_totalScore += 2;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste le passage au troisième mode image
        ///</summary>
        [TestMethod()]
        public void T15_Frm_PasserAuTroisièmeMode()
        {
            m_maxScore += 2;

            FrmPrincipal target = new FrmPrincipal();

            target.BtnModeImageSuivant_Click(target, EventArgs.Empty);
            target.BtnModeImageSuivant_Click(target, EventArgs.Empty);
            Assert.AreEqual("Cinéma", target.lblNomModeImage.Text);
            Assert.AreEqual(70, target.vsiLuminosité.Value);
            Assert.AreEqual(40, target.vsiContraste.Value);
            Assert.AreEqual(40, target.vsiCouleur.Value);
            Assert.AreEqual(-1, target.vsiTeinte.Value);
            Assert.AreEqual(2, target.vsiNetteté.Value);


            m_totalScore += 2;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste le retour au premier mode image
        ///</summary>
        [TestMethod()]
        public void T16_Frm_RetourAuPremimerMode()
        {
            m_maxScore += 2;
            FrmPrincipal target = new FrmPrincipal();

            target.BtnModeImageSuivant_Click(target, EventArgs.Empty);
            target.BtnModeImageSuivant_Click(target, EventArgs.Empty);
            target.BtnModeImageSuivant_Click(target, EventArgs.Empty);

            Assert.AreEqual("Sport", target.lblNomModeImage.Text);
            Assert.AreEqual(90, target.vsiLuminosité.Value);
            Assert.AreEqual(60, target.vsiContraste.Value);
            Assert.AreEqual(50, target.vsiCouleur.Value);
            Assert.AreEqual(0, target.vsiTeinte.Value);
            Assert.AreEqual(6, target.vsiNetteté.Value);

            m_totalScore += 2;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste le retour au premier mode image
        ///</summary>
        [TestMethod()]
        public void T17_Frm_MémoriserLesAjustements()
        {
            m_maxScore += 7;
            FrmPrincipal target = new FrmPrincipal();

            target.vsiLuminosité.Value = 3;
            target.vsiContraste.Value = 6;
            target.vsiCouleur.Value = 9;
            target.vsiTeinte.Value = -4;
            target.vsiNetteté.Value = 8;

            target.BtnMémoriser_Click(target, EventArgs.Empty);

            target.vsiLuminosité.Value = 0;
            target.vsiContraste.Value = 0;
            target.vsiCouleur.Value = 0;
            target.vsiTeinte.Value = 0;
            target.vsiNetteté.Value = 0;

            target.BtnModeImageSuivant_Click(target, EventArgs.Empty);
            target.BtnModeImageSuivant_Click(target, EventArgs.Empty);
            target.BtnModeImageSuivant_Click(target, EventArgs.Empty);

            Assert.AreEqual("Sport", target.lblNomModeImage.Text);
            Assert.AreEqual(3, target.vsiLuminosité.Value);
            Assert.AreEqual(6, target.vsiContraste.Value);
            Assert.AreEqual(9, target.vsiCouleur.Value);
            Assert.AreEqual(-4, target.vsiTeinte.Value);
            Assert.AreEqual(8, target.vsiNetteté.Value);

            m_totalScore += 7;
        }

#endif
        #endregion
    }
}
 