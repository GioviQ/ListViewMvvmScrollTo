using ListViewMvvmScrollTo.Models;
using Prism.Navigation;
using System.Collections.Generic;

namespace ListViewMvvmScrollTo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private List<MyItem> _myBookmarks;
        public List<MyItem> MyBookmarks { get => _myBookmarks; private set { SetProperty(ref _myBookmarks, value); } }

        private MyItem _selectedBookmark;
        public MyItem SelectedBookmark
        {
            get => _selectedBookmark;
            set
            {
                SetProperty(ref _selectedBookmark, value);

                if (value != null)
                    NavigationService.NavigateAsync($"ListPage?bookmark={value.Id}");
            }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Bookmarks";

            MyBookmarks = new List<MyItem>();

            MyBookmarks.Add(new MyItem() { Id = 37 });
            MyBookmarks.Add(new MyItem() { Id = 68 });
            MyBookmarks.Add(new MyItem() { Id = 99 });
        }
    }
}
