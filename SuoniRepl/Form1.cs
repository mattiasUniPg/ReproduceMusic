using System;
using System.Windows.Forms;
using System.Media; //libreria file audio


namespace SuoniRepl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer musica = new SoundPlayer("Why_-_TALIS'MAN_FAMILY_-_Soldiah_Beez (online-audio-converter.com).wav");//oggetto della classe Sound 
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //metodo
            musica.Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            musica.Stop(); //stoppare la canzone
        }
    }
}