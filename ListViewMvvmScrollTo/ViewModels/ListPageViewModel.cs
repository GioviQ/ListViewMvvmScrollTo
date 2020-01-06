using ListViewMvvmScrollTo.Models;
using Prism.Navigation;
using System.Collections.Generic;

namespace ListViewMvvmScrollTo.ViewModels
{
    public class ListPageViewModel : ViewModelBase
    {
        private List<MyItem> _myItems;
        public List<MyItem> MyItems { get => _myItems; private set { SetProperty(ref _myItems, value); } }

        private MyItem _bookmark;
        public MyItem Bookmark
        {
            get => _bookmark;
            set { SetProperty(ref _bookmark, value); }
        }
        public ListPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Items";

            MyItems = new List<MyItem>();

            for (int i = 1; i <= 100; i++)
                MyItems.Add(new MyItem() { Id = i });
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("bookmark"))
                Bookmark = new MyItem() { Id = parameters.GetValue<int>("bookmark") };
        }
    }
}
