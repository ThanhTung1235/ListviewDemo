using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AgainUWP.DataAccessLibrary;
using AgainUWP.Entity;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AgainUWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListView_demo : Page
    {
        private ObservableCollection<Song> listSong;

        internal ObservableCollection<Song> ListSong { get => listSong; set => listSong = value; }

        public ListView_demo()
        {
            this.InitializeComponent();
            this.ListSong = new ObservableCollection<Song>();
            this.ListSong.Add(new Song()
            {
                name = "Thằng điên",
                thumbnail = "https://i.ytimg.com/vi/HXkh7EOqcQ4/maxresdefault.jpg"
            });
            this.listSong.Add(new Song()
            {
                name = "Thằng điên",
                thumbnail = "https://i.ytimg.com/vi/HXkh7EOqcQ4/maxresdefault.jpg"
            });
            this.listSong.Add(new Song()
            {
                name = "Thằng điên",
                thumbnail = "https://i.ytimg.com/vi/HXkh7EOqcQ4/maxresdefault.jpg"
            });
            this.listSong.Add(new Song()
            {
                name = "Thằng điên",
                thumbnail = "https://i.ytimg.com/vi/HXkh7EOqcQ4/maxresdefault.jpg"
            });
            this.listSong.Add(new Song()
            {
                name = "Thằng điên",
                thumbnail = "https://i.ytimg.com/vi/HXkh7EOqcQ4/maxresdefault.jpg"
            });
            this.InitializeComponent();
        }

        private void btn_add(object sender, RoutedEventArgs e)
        {
            Song c = new Song()
            {
                name = name.Text,
                thumbnail = thumbnail.Text,

            };
            SongModel.Add(c);
        }

    }
}
