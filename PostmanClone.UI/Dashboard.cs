namespace PostmanClone.UI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void CallApiOnClick(object sender, EventArgs e)
        {

            // validate URL input.



            try
            {
                toolStripStatusLabel.Text = "Calling API......";

                resultText.Text = "Called api: ";

                // call api

                await Task.Delay(2000);

                toolStripStatusLabel.Text = "Ready";

            }
            catch (Exception ex)
            {

                resultText.Text = "Error: " +  ex.Message;
                toolStripStatusLabel.Text = "Error";
                
            }

        }
    }
}
