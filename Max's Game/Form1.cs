using System.Media;
namespace Max_s_Game
{
    public partial class MaxsGame : Form
    {
        public MaxsGame()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            SoundPlayer buttonSound = new SoundPlayer(Resource1.button);
            buttonSound.Play();
            playButton.Visible = false;
            countdown.ForeColor = Color.White;
            Refresh();

            Thread.Sleep(1000);
            countdown.Text = "Starting in 2...";
            Refresh();

            Thread.Sleep(1000);
            countdown.Text = "Starting in 1...";
            Refresh();

            Thread.Sleep(1000);
            countdown.Location = new Point(300, 0);
            countdown.ForeColor = Color.Black;
            buttonSound.Play();
            go.ForeColor = Color.Green;
        }

        private void go_Click(object sender, EventArgs e)
        {

        }

        private void MaxGame_Load(object sender, EventArgs e)
        {

        }

        private void countdown_Click(object sender, EventArgs e)
        {

        }
    }
}