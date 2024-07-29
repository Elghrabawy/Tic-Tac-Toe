namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        bool checker = false;
        int playerxScore = 0, playeroScore = 0;

        void Enable_Flase()
        {
            btnTic00.Enabled = false;
            btnTic01.Enabled = false;
            btnTic02.Enabled = false;
            btnTic10.Enabled = false;
            btnTic11.Enabled = false;
            btnTic12.Enabled = false;
            btnTic20.Enabled = false;
            btnTic21.Enabled = false;
            btnTic22.Enabled = false;
        }

        void Enable_True()
        {
            btnTic00.Enabled = true;
            btnTic01.Enabled = true;
            btnTic02.Enabled = true;
            btnTic10.Enabled = true;
            btnTic11.Enabled = true;
            btnTic12.Enabled = true;
            btnTic20.Enabled = true;
            btnTic21.Enabled = true;
            btnTic22.Enabled = true;
        }

        void newGame()
        {
            try
            {
                checker = false;
                Enable_True();

                btnTic00.Text = "";
                btnTic01.Text = "";
                btnTic02.Text = "";
                btnTic10.Text = "";
                btnTic11.Text = "";
                btnTic12.Text = "";
                btnTic20.Text = "";
                btnTic21.Text = "";
                btnTic22.Text = "";


                btnTic00.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                btnTic01.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                btnTic02.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                btnTic10.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                btnTic11.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                btnTic12.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                btnTic20.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                btnTic21.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                btnTic22.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void resetGame()
        {
            playerxScore = 0;
            playeroScore = 0;
            lblPlayerxScore.Text = "0";
            lblPlayeroScore.Text = "0";
            newGame();
        }

        void score()
        {
            /*
             * Player X conditions
             */
            // check x in row 0 
            if (btnTic00.Text == "X" && btnTic01.Text == "X" && btnTic02.Text == "X")
            {

                btnTic00.DisabledState.FillColor = Color.Green;
                btnTic01.DisabledState.FillColor = Color.Green;
                btnTic02.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playerxScore++;
                lblPlayerxScore.Text = playerxScore.ToString();
                Enable_Flase();
            }

            // check x in row 1
            if (btnTic10.Text == "X" && btnTic11.Text == "X" && btnTic12.Text == "X")
            {

                btnTic10.DisabledState.FillColor = Color.Green;
                btnTic11.DisabledState.FillColor = Color.Green;
                btnTic12.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playerxScore++;
                lblPlayerxScore.Text = playerxScore.ToString();
                Enable_Flase();
            }

            // check x in row 2
            if (btnTic20.Text == "X" && btnTic21.Text == "X" && btnTic22.Text == "X")
            {

                btnTic20.DisabledState.FillColor = Color.Green;
                btnTic21.DisabledState.FillColor = Color.Green;
                btnTic22.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playerxScore++;
                lblPlayeroScore.Text = playerxScore.ToString();
                Enable_Flase();
            }

            // check x in column 0
            if (btnTic00.Text == "X" && btnTic10.Text == "X" && btnTic20.Text == "X")
            {

                btnTic00.DisabledState.FillColor = Color.Green;
                btnTic10.DisabledState.FillColor = Color.Green;
                btnTic20.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playerxScore++;
                lblPlayerxScore.Text = playerxScore.ToString();
                Enable_Flase();
            }

            // check x in column 1
            if (btnTic01.Text == "X" && btnTic11.Text == "X" && btnTic21.Text == "X")
            {
                btnTic01.DisabledState.FillColor = Color.Green;
                btnTic11.DisabledState.FillColor = Color.Green;
                btnTic21.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playerxScore++;
                lblPlayerxScore.Text = playerxScore.ToString();
                Enable_Flase();
            }

            // check x in column 2
            if (btnTic02.Text == "X" && btnTic12.Text == "X" && btnTic22.Text == "X")
            {
                btnTic02.DisabledState.FillColor = Color.Green;
                btnTic12.DisabledState.FillColor = Color.Green;
                btnTic22.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playerxScore++;
                lblPlayerxScore.Text = playerxScore.ToString();
                Enable_Flase();
            }

            // check x in diagonal 1
            if (btnTic00.Text == "X" && btnTic11.Text == "X" && btnTic22.Text == "X")
            {
                btnTic00.DisabledState.FillColor = Color.Green;
                btnTic11.DisabledState.FillColor = Color.Green;
                btnTic22.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playerxScore++;
                lblPlayerxScore.Text = playerxScore.ToString();
                Enable_Flase();
            }

            // check x in diagonal 2
            if (btnTic02.Text == "X" && btnTic11.Text == "X" && btnTic20.Text == "X")
            {
                btnTic02.DisabledState.FillColor = Color.Green;
                btnTic11.DisabledState.FillColor = Color.Green;
                btnTic20.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playerxScore++;
                lblPlayerxScore.Text = playerxScore.ToString();
                Enable_Flase();
            }

            /*
             * Player O conditions
             */
            // check o in row 0
            if (btnTic00.Text == "O" && btnTic01.Text == "O" && btnTic02.Text == "O")
            {
                btnTic00.DisabledState.FillColor = Color.Green;
                btnTic01.DisabledState.FillColor = Color.Green;
                btnTic02.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playeroScore++;
                lblPlayeroScore.Text = playeroScore.ToString();
                Enable_Flase();
            }

            // check o in row 1
            if (btnTic10.Text == "O" && btnTic11.Text == "O" && btnTic12.Text == "O")
            {
                btnTic10.DisabledState.FillColor = Color.Green;
                btnTic11.DisabledState.FillColor = Color.Green;
                btnTic12.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playeroScore++;
                lblPlayeroScore.Text = playeroScore.ToString();
                Enable_Flase();
            }

            // check o in row 2
            if (btnTic20.Text == "O" && btnTic21.Text == "O" && btnTic22.Text == "O")
            {
                btnTic20.DisabledState.FillColor = Color.Green;
                btnTic21.DisabledState.FillColor = Color.Green;
                btnTic22.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playeroScore++;
                lblPlayeroScore.Text = playeroScore.ToString();
                Enable_Flase();
            }

            // check o in column 0
            if (btnTic00.Text == "O" && btnTic10.Text == "O" && btnTic20.Text == "O")
            {
                btnTic00.DisabledState.FillColor = Color.Green;
                btnTic10.DisabledState.FillColor = Color.Green;
                btnTic20.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playeroScore++;
                lblPlayeroScore.Text = playeroScore.ToString();
                Enable_Flase();
            }

            // check o in column 1
            if (btnTic01.Text == "O" && btnTic11.Text == "O" && btnTic21.Text == "O")
            {
                btnTic01.DisabledState.FillColor = Color.Green;
                btnTic11.DisabledState.FillColor = Color.Green;
                btnTic21.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playeroScore++;
                lblPlayeroScore.Text = playeroScore.ToString();
                Enable_Flase();
            }

            // check o in column 2
            if (btnTic02.Text == "O" && btnTic12.Text == "O" && btnTic22.Text == "O")
            {
                btnTic02.DisabledState.FillColor = Color.Green;
                btnTic12.DisabledState.FillColor = Color.Green;
                btnTic22.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playeroScore++;
                lblPlayeroScore.Text = playeroScore.ToString();
                Enable_Flase();
            }

            // check o in diagonal 1
            if (btnTic00.Text == "O" && btnTic11.Text == "O" && btnTic22.Text == "O")
            {
                btnTic00.DisabledState.FillColor = Color.Green;
                btnTic11.DisabledState.FillColor = Color.Green;
                btnTic22.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playeroScore++;
                lblPlayeroScore.Text = playeroScore.ToString();
                Enable_Flase();
            }

            // check o in diagonal 2
            if (btnTic02.Text == "O" && btnTic11.Text == "O" && btnTic20.Text == "O")
            {
                btnTic02.DisabledState.FillColor = Color.Green;
                btnTic11.DisabledState.FillColor = Color.Green;
                btnTic20.DisabledState.FillColor = Color.Green;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playeroScore++;
                lblPlayeroScore.Text = playeroScore.ToString();
                Enable_Flase();
            }


            /*
             * Draw Condition
             */
            if (btnTic00.Text != "" && btnTic01.Text != "" && btnTic02.Text != "" && btnTic10.Text != "" && btnTic11.Text != "" && btnTic12.Text != "" && btnTic20.Text != "" && btnTic21.Text != "" && btnTic22.Text != "")
            {
                MessageBox.Show("The game is a draw", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_Flase();
            }
        }

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTic00_Click(object sender, EventArgs e)
        {
            btnTic00.Text = checker ? "X" : "O";
            checker = !checker;
            score();
            btnTic00.Enabled = false;
        }

        private void btnTic01_Click(object sender, EventArgs e)
        {
            btnTic01.Text = checker ? "X" : "O";
            checker = !checker;
            score();
            btnTic01.Enabled = false;
        }

        private void btnTic02_Click(object sender, EventArgs e)
        {
            btnTic02.Text = checker ? "X" : "O";
            checker = !checker;
            score();
            btnTic02.Enabled = false;
        }

        private void btnTic10_Click(object sender, EventArgs e)
        {
            btnTic10.Text = checker ? "X" : "O";
            checker = !checker;
            score();
            btnTic10.Enabled = false;
        }

        private void btnTic11_Click(object sender, EventArgs e)
        {
            btnTic11.Text = checker ? "X" : "O";
            checker = !checker;
            score();
            btnTic11.Enabled = false;
        }

        private void btnTic12_Click(object sender, EventArgs e)
        {
            btnTic12.Text = checker ? "X" : "O";
            checker = !checker;
            score();
            btnTic12.Enabled = false;
        }

        private void btnTic20_Click(object sender, EventArgs e)
        {
            btnTic20.Text = checker ? "X" : "O";
            checker = !checker;
            score();
            btnTic20.Enabled = false;
        }

        private void btnTic21_Click(object sender, EventArgs e)
        {
            btnTic21.Text = checker ? "X" : "O";
            checker = !checker;
            score();
            btnTic21.Enabled = false;
        }

        private void btnTic22_Click(object sender, EventArgs e)
        {
            btnTic22.Text = checker ? "X" : "O";
            checker = !checker;
            score();
            btnTic22.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}