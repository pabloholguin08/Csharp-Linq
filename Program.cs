LinqQueries queries = new LinqQueries();

//Toda la colección
//ImprimirValores(queries.TodaLaColeccion());

//Libros después del 2000
//ImprimirValores(queries.LibrosDespuesdel20000());

//Libros coon más de 250 pag y tienen en el titulo la palabra in action
//ImprimirValores(queries.LibrosConMasde250PagConPalabrasInAction());

//Todos los libros tienen status
//Console.WriteLine($" Todos los libros tienen status? - {queries.TodoslosLibrosconStatus()}");

//Si algun libro fue publicado en 2005
//Console.WriteLine($" Algún libro fue publicado en 2005?{queries.SiAlgunLibroDespues2005}");

//Libros de Python
//ImprimirValores(queries.LibrosConPython());

//Libros de java por nombre
//ImprimirValores(queries.LibrosDeJavaAsc());

//Libros que tienen más de 450 paginas de forma descendente
ImprimirValores(queries.LibrosDeJavaDesc());

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1,15} {2,15}\n", "Titulo", "N. Paginas", "Fecha Publicacion");
    foreach (var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}



/*
<code> 
List<Animal> animales = new List<Animal>();
        animales.Add(new Animal() { Nombre = "Hormiga", Color = "Rojo" });
        animales.Add(new Animal() { Nombre = "Lobo", Color = "Gris" });
        animales.Add(new Animal() { Nombre = "Elefante", Color = "Gris" });
        animales.Add(new Animal() { Nombre = "Pantegra", Color = "Negro" });
        animales.Add(new Animal() { Nombre = "Gato", Color = "Negro" });
        animales.Add(new Animal() { Nombre = "Iguana", Color = "Verde" });
        animales.Add(new Animal() { Nombre = "Sapo", Color = "Verde" });
        animales.Add(new Animal() { Nombre = "Camaleon", Color = "Verde" });
        animales.Add(new Animal() { Nombre = "Gallina", Color = "Blanco" });

        List<char> vocales = new List<char>() { 'a', 'e', 'i', 'o', 'u' };        

        List<Animal> result = animales.Where(x => x.Color.ToLower().Equals("verde") && vocales.Contains(x.Nombre.ToLower()[0])).ToList();

        if (result.Any())
            result.ForEach(x => Console.WriteLine(x.Nombre));
*/