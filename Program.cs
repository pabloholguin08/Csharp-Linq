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
//ImprimirValores(queries.LibrosDeJavaDesc());

//3 libros más recientes de Java
//ImprimirValores(queries.TresLibrosDeJavaRecientes());

//Tercer y Cuarto libro con más de 400 pag
//ImprimirValores(queries.TerceryCuartoLibroDeMas400Pag());

//3 Primeros  libros filtrados con select
//ImrpimirValores(queries.TresPrimerosLibros());

//Cantidad de libros con entre 200 y 500 paginas}
//Console.WriteLine($"Cantidad de libros que tienen entre 200 y 500 pag. {queries.NumeroLibrosConPaginasEntre200y500()}");

//Fecha de Publicación Menor
//Console.WriteLine($"Fecha de Publicación menor: {queries.FechaDePublicacionMenor()}");

//Numero de paginas del libro que más contiene
//Console.WriteLine($"Numero de paginas del libro que más contiene: {queries.NumeroDePagLibroMayor}");

//Libro con menor numero de paginas
//var book = queries.LibroConMenorNumerodePaginas();
//Console.WriteLine($"Libro con menos paginas: {book.Title} - {book.PageCount}");

//Libro más reciente
//var book = queries.LibroConFechaPublicacionMasReciente();
//Console.WriteLine($"Libro más reciente: {book.Title} - {book.PublishedDate.ToShortDateString()}");

//La suma total de páginas de libros entre 0 y 500
//Console.WriteLine($"Suma total de paginas: {queries.SumaPaginasLibrosEntr0y500()}");

//Libros despues del 2015
//Console.WriteLine(queries.TitulosDelLibroDespuesdel2O15());

//Promedio de caracteres en titulos
//Console.WriteLine($"El promedio de caracteres es: {queries.PromedioCaracteresTitulo()}");

//Libros por año después del 2000
//ImprimirGrupo(queries.LibrosDespuesDel200AgrupadosPorAnio());

//Diccionario de libros agrupados por primera Letra del titulo
//var diccionarioLookup = queries.DiccionarioDeLibrosPorLetra();
//ImprimirDiccionario(diccionarioLookup, 'A');

//Libros filtrados con la clausula join
ImprimirValores(queries.LibrosDespuesdel2005conMasde500Pags());


void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1,15} {2,15}\n", "Titulo", "N. Paginas", "Fecha Publicacion");
    foreach (var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}


void ImprimirGrupo(IEnumerable<IGrouping<int,Book>> ListadeLibros)
{
    foreach(var grupo in ListadeLibros)
    {
        Console.WriteLine("");
        Console.WriteLine($"Grupo: { grupo.Key }");
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach(var item in grupo)
        {
            Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
        }
    }
}

void ImprimirDiccionario(ILookup<char, Book> listadeLibros, char letra)
{
    char letterUpper = Char.ToUpper(letter);
    if (listBooks[letterUpper].Count() == 0)
    {
        Console.WriteLine($"No hay libros que inicien con la letra '{letterUpper}'");
    } 
    else 
    {
        Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Título", "Nro. Páginas", "Fecha de Publicación");
        foreach (var book in listBooks[letterUpper])
        {
            Console.WriteLine("{0, -60} {1, 15} {2, 15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
        }
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



