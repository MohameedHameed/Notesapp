using Notesapp.Viewmodels;

namespace Notesapp.Views;

public partial class Noteview : ContentView
{
    public Newviewmodel Notview { get; }
 
    public Noteview(Newviewmodel notview)
	{
		InitializeComponent();
        BindingContext = notview;
        Notview = notview;
      


    }

    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Notview.adddatatonui();
        
      
    }
}