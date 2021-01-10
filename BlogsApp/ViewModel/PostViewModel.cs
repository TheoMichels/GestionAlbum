using System;
using System.Collections.Generic;
using System.Text;

namespace BlogsApp
{
    public class PostViewModel : Observable
    {
        private readonly Post _model;

        public PostViewModel()
        {
            _model = new Post();
        }

        public PostViewModel(Post model)
        {
            _model = model;
        }

        public override string ToString()
        {
            return TitreAuteur;
        }

        public string Auteur
        {
            get => _model.Auteur;
            set { _model.Auteur = value; OnPropertyChanged(nameof(Auteur)); OnPropertyChanged(nameof(TitreAuteur)); }
        }

        public string Titre
        {
            get => _model.Titre;
            set { _model.Titre = value; OnPropertyChanged(nameof(Titre)); OnPropertyChanged(nameof(TitreAuteur)); }
        }

        public string TitreAuteur => $"{_model.Titre} - {_model.Auteur}";

        public string Contenu
        {
            get => _model.Contenu;
            set { _model.Contenu = value; OnPropertyChanged(nameof(Contenu)); }
        }
    }

    // Entity Framework
    //
    public class Post
    {
        public int Id { get; set; }

        public string Auteur { get; set; }

        public string Titre { get; set; }

        public string Contenu { get; set; }
    }
}
