namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new Personnage();
        Personnage dragon = new Personnage();

        public Form1()
        {
            InitializeComponent();
            //DateTime momentPresent = DateTime.Now;
            // momentPresent.Year = 2025; erreur car objet DateTime a des propri�t�s en lecture seule

            joueur.PointsDeVie = 10;
            joueur.PointsDePuissance = 1;

            dragon.PointsDeVie = 30; // ou joueur.PointeDeVie * 3;
            dragon.PointsDePuissance = 3;

        }

        private void ActualiserLabels()
        {
            lbl_pointsVieJoueur.Text = "Vie du joueur : " + joueur.PointsDeVie.ToString();
            lbl_pointsVieDragon.Text = "Vie du dragon : " + dragon.PointsDeVie.ToString();
            lbl_puissanceAttaqueJoueur.Text = "Attaque du joueur : " + joueur.PointsDePuissance.ToString();
            lbl_puissanceAttaqueDragon.Text = "Attaque du dragon : " + dragon.PointsDePuissance.ToString();

        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointsDeVie -= joueur.PointsDePuissance;
            ActualiserLabels();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            ActualiserLabels();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            ActualiserLabels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLabels();
        }
    }
}