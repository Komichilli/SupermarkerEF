namespace SupermarkerEF;
using Microsoft.EntityFrameworkCore;
using SupermarkerEF.Data;
using SupermarkerEF.Models;

internal class Program
{

    static void Main(string[] args)
    {
        using SupermarketContext context = new SupermarketContext();
      /*
        // Se crea el objeto oilCategory de tipo Category

        Category oilCategory = new Category()
        {
            Name = "Oil",
            Description = "Oil Category"

        };

        // Se agrega el objeto creado al contexto de la BD
        // Usando la propiedad Categories del contexto
        context.Categories.Add(oilCategory);

        // Se crea el objeto grainsCategory de tipo Category
       Category grainsCategory = new Category()
        {

            Name = "Grains",
            Description = "Grains Category"

        };
  
        // Se agrega el objeto creado al contexto de la BD
         context.Add(grainsCategory);

        //Se graban las cambios realizados al contexto
         context.SaveChanges(); */
        //Recupera todas las categorias y las ordena por el nombre

        var grainsCategory = context.Categories
            .Where(p => p.Name == "Grains")
            .FirstOrDefault();
        if (grainsCategory is Category)
        {
            grainsCategory.Description = "New description applied";
            context.Remove(grainsCategory);

        }
        context.SaveChanges();

        var categories = context.Categories.OrderBy(p => p.Name);

        foreach (var category in categories)
        {

            Console.WriteLine($"{category.Name} | {category.Description}");

        }
    }
}
