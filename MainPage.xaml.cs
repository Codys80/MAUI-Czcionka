namespace MAUI_Czcionka
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        short index = 1;
        int fontSize = 14;
        string[] message = { "Dzień dobry", "Good morning","Buenos dias" };
        private void OnFontSliderChange(object sender, EventArgs e)
        {
            fontSize = Convert.ToUInt16(fontSlider.Value);
            messageDisplay.FontSize = fontSize;
            fontSizeDisplay.Text = "Rozmiar: " + fontSize.ToString();
        }
        private void OnDisplayButtonClicked(object sender, EventArgs e)
        {

            switch (index)
            {
                case 0:
                    messageDisplay.Text = message[0];
                    index++;
                    break;
                case 1:
                    messageDisplay.Text = message[1];
                    index++;
                    break;
                case 2:
                    messageDisplay.Text = message[2];
                    index = 0;
                    break;
            }
        }
    }

}
