public class LinqQueries
{
    private List<Book> librosCollection = new List<Book>();
    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }

    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosCollection;
    }

    public IEnumerable<Book> LibrosDespuesdel20000()
    {
        //Extension Method
        //return librosCollection.Where(p => p.PublishedDate.Year > 2000);

        //Query Expresion
        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
    }

    public IEnumerable<Book> LibrosConMasde250PagConPalabrasInAction()
    {
        //Extension Method
        //return librosCollection.Where(p => p.PageCount > 250 && p.Title.Contains("in Action"));

        //Query Expresion
        return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action") select l;
    }

    public bool TodoslosLibrosconStatus()
    {
        //All, todos los datos cumplen la condición
        return librosCollection.All(p => p.Status != string.Empty);
    }

    public bool SiAlgunLibroDespues2005()
    {
        //Any, algún elemento cumple la condición
        return librosCollection.Any(p => p.PublishedDate.Year == 2005);
    }

    public IEnumerable<Book> LibrosConPython()
    {
        //Extension Method
        return librosCollection.Where(p => p.Categories.Contains("Python"));

        //Query Expresion
        //return from l in librosCollection where l.Categories.Contains("Python") select l;
    }

    public IEnumerable<Book> LibrosDeJavaAsc()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java").OrderBy(p => p.Title));
    }

    public IEnumerable<Book> LibrosDeJavaDesc()
    {
        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
    }

    public IEnumerable<Book> TresLibrosDeJavaRecientes()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java").OrderByDescending(p => p.PublishedDate).Take(3));
    }

    public IEnumerable<Book> TerceryCuartoLibroDeMas400Pag()
    {
        return librosCollection.Where(p => p.PageCount > 400).Take(4).Skip(2);
    }

    public IEnumerable<Book> TresPrimerosLibros()
    {
        return librosCollection.Take(3).Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });
    }

    public int NumeroLibrosConPaginasEntre200y500()
    {
        return librosCollection.Where(p => p.PageCount >= 200 && p.PageCount <= 500).Count();
    }

    public long NumeroLibrosConPaginasEntre200y500()
    {
        return librosCollection.Where(p => p.PageCount >= 200 && p.PageCount <= 500).LongCount();
        //return librosCollection.LongCount(p => p.PageCount >=200 && p.PageCount<=500);
    }

    public DateTime FechaDePublicacionMenor()
    {
        return librosCollection.Min(p => p.PublishedDate.ToShortDateString());
    }

    public int NumeroDePagLibroMayor()
    {
        return librosCollection.Max(p => p.PageCount);
    }

    public Book LibroConMenorNumerodePaginas()
    {
        return librosCollection.Where(p => p.PageCount > 0).MinBy(p => p.PageCount);
    }

    public Book LibroConFechaPublicacionMasReciente()
    {
        return librosCollection.MaxBy(p => p.PublishedDate);

        /*
        public Book? recentPublishDateBook(IEnumerable<Book> books){
        return books.MaxBy(b=>b.PublishedDate) is null? new Book(): books.MaxBy(b=>b.PublishedDate);
        }
        */
    }

    public int SumaPaginasLibrosEntre0y500(){
        return librosCollection.Where(p=>p.PageCount >= 0 && p.PageCount <=500).Sum(p=> p.PageCount);
    }

    public string TitulosDelLibroDespuesdel2O15(){
        return librosCollection.Where(p=> p.PublishedDate.Year > 2015).Aggregate("",(TitulosLibros, next) =>{
            if(TitulosLibros != string.Empty){
                TitulosLibros += " - " + next.Title;
            }else{
                TitulosLibros += next.Title;
            }
            return TitulosLibros;
        });
    }
}