using MoreNote.MSync.Services;

namespace MoreNoteMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Task task = new Task(() =>
            {
                WebSocketService socketService=new WebSocketService();
                socketService.Start();
            });
            task.Start();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           
        }
    }

}
