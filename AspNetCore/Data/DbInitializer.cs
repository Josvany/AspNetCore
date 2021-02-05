using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Models;

namespace AspNetCore.Data
{
    public class DbInitializer
    {
        public static void Initializt (AspNetCoreContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria { categoriaName = "Programacion",
                                catgoriaDescription = "Programacion",
                                categoriaStatus = true
                              },

                new Categoria { categoriaName = "Diseño Grafico",
                                catgoriaDescription = "Diseño Grafico",
                                categoriaStatus = true
                              }
            };

            foreach (Categoria item in categorias)
            {
                context.Add(item);
            }
            context.SaveChanges();

        }
    }
}