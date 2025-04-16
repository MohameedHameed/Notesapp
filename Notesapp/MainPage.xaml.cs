using Notesapp.Viewmodels;

namespace Notesapp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            container.Content =new  Views.Noteview(new Newviewmodel(this));
        }


    }

}
