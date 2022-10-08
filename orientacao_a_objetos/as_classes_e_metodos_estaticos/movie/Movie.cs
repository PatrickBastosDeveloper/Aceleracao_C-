namespace cine;
class Movie {
  public string Title { get; set; }
  public string Category {
    get { return _category; }
    set { 
          if(value != "Fantasia" && value != "Ficção Científica")
          {
            throw new Exception("Category not allowed");
          }
      _category = value;
    }
  }

  string _category;
  public Movie(string title, string category)
  {
    Title = title;
    Category = category;
  }
}