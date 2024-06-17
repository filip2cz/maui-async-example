using System.Diagnostics;

namespace maui_async_example
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTimerClicked(object sender, EventArgs e)
        {
            count = 11;
            TimerBtn.IsVisible = false;

            while (count > 0)
            {
                count = await Subtract(count);
                Clock.Text = $"Counting: {count}";
                await Task.Delay(1000);
            }

            TimerBtn.IsVisible = true;
        }
        public async Task<int> Subtract(int x)
        {
            Debug.WriteLine($"DEBUG: Suntract(): Subtracting {x}");
            return --x;
        }
    }

}
