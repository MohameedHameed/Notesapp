using Notesapp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Notesapp.Data;
using Notesapp.Views;
namespace Notesapp.Viewmodels
{
    public partial class Newviewmodel : ObservableObject
    {
        MainPage MainPage;
        BookAuthorEnity bookAuthorEntity;
        [ObservableProperty]
         string book_id;
        [ObservableProperty]
         string autor_id;
  
        [ObservableProperty]
      public BookAuthor selectedBookAuthor;
        [ObservableProperty]
     public   ObservableCollection<BookAuthor> noteCollection;

 

        public Newviewmodel(MainPage MainPage) {
            this.MainPage = MainPage;
            NoteCollection=new ObservableCollection<BookAuthor>();
            bookAuthorEntity = new BookAuthorEnity();
            loaddata();
        }
        // [RelayCommand]
        /* private async void EditNote(object obj)
         {

             if (Selectednote != null)
             {
                 BookAuthor bookAuthor = new BookAuthor
                 {
                     Id = selectedBookAuthor.Id,
                     Title = NoteTitle,
                     Description = NoteDescription,
                     AuthorId = Autor_id
                 };
                await noteEntity.UpdateDataAsync(newnote);
                 loaddata();

             }

         }*/
        /*  [RelayCommand]

          private void DeleteNote(object obj)
          {
              if (selectedBookAuthor != null)
              {
                    noteEntity.DeleteDataAsync(selectedBookAuthor);
                  loaddata();
                  NoteTitle = string.Empty;
                  NoteDescription = string.Empty;
              }
          }*/
        [RelayCommand]

        private async void AddNote(object obj)
        {

            BookAuthor bookAuthor = new BookAuthor
            {
                BookId =int.Parse( Book_id),
                AuthorId = int.Parse (Autor_id),
            };

         string d=  await bookAuthorEntity.AddDataAsync(bookAuthor);
            if (d == "sucess") {
                loaddata();
                Book_id = string.Empty;
                Autor_id = string.Empty;
                MainPage.DisplayAlert("Ok", d,"cancel");
            }
            else
            {
                MainPage.DisplayAlert("filed", d, "cancel");
            }
          
        }
        public void adddatatonui()
        {
            Book_id = SelectedBookAuthor.BookId.ToString();
            Autor_id = SelectedBookAuthor.AuthorId.ToString();
        }

        public async void  loaddata()
        {
            NoteCollection.Clear();
            foreach (BookAuthor bookAuthor in await bookAuthorEntity.GetAllAsync())
            {
                NoteCollection.Add(bookAuthor);
            }
         
        }

    
    }
}
