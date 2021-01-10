using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BlogsApp
{
    public class MainViewModel : Observable
    {
        public MainViewModel()
        {
            _posts = new ObservableCollection<PostViewModel>
            {
                new PostViewModel() { Auteur = "JRR Tolkien", Titre = "Le Hobbit" } ,
                new PostViewModel() { Auteur = "JRR Tolkien", Titre = "Le Seigneur des Anneaux" },
                new PostViewModel() { Auteur = "JRR Tolkien", Titre = "Le Silmarillon" }
            };

            _selectedPost = _posts[0];
        }

        private readonly ObservableCollection<PostViewModel> _posts;
        public ObservableCollection<PostViewModel> Posts
        {
            get { return _posts; }
        }

        private PostViewModel _selectedPost;
        public PostViewModel SelectedPost
        {
            get => _selectedPost;
            set => SetProperty(ref _selectedPost, value);
        }

        public void AddPost()
        {
            PostViewModel p = new PostViewModel();
            p.Titre = "Nouveau post";

            _posts.Add(p);
            SelectedPost = p;
        }

        public void RemovePost()
        {
            if (_selectedPost != null)
            {
                _posts.Remove(_selectedPost);
                SelectedPost = null;
            }
        }
    }
}
