namespace DestinyItemTagger
{
    using System.Windows.Forms;

    /// <summary>
    /// Splash Form.
    /// </summary>
    public partial class Splash : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Splash"/> class.
        /// </summary>
        public Splash()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Splash"/> class.
        /// Displays Hello message.
        /// </summary>
        /// <param name="allowLaunch">Launch app.</param>
        /// <param name="message">Message to display.</param>
        public void SendMessage(bool allowLaunch, string message)
        {
            this.txtMessage.Text = this.txtMessage.Text + message + System.Environment.NewLine;
            if (allowLaunch)
            {
                this.txtMessage.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                this.txtMessage.BackColor = System.Drawing.Color.LightSalmon;
            }
        }

        /// <summary>
        /// Sets the button text.
        /// </summary>
        /// <param name="text">Button text.</param>
        public void SetButtonText(string text)
        {
            this.btnAction.Text = text;
        }

        private void BtnAction_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}