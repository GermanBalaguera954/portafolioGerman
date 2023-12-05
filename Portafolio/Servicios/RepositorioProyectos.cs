using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo = "Globant",
                Descripcion = "E-Commerce realizado en ASP.NET Core",
                Link = "https://www.globant.com/es",
                ImagenURL = "/imagenes/globant.jpeg"
            },
                new Proyecto
            {
                Titulo = "Pragma",
                Descripcion = "Transformando empresas",
                Link = "https://www.pragma.co/es/",
                ImagenURL = "/imagenes/pragma.png"
            },
                new Proyecto
            {
                Titulo = "Mercado Libre",
                Descripcion = "La ruta mas eficiente para el transporte",
                Link = "https://www.mercadolibre.com.co/",
                ImagenURL = "/imagenes/MercadoLibre.jpg"
            },
                new Proyecto
            {
                Titulo = "Sofka",
                Descripcion = "Servicio para la transformación tecnológica",
                Link = "https://www.sofka.com.co/es/inicio/",
                ImagenURL = "/imagenes/sofka.png"
            },
            };
        }
    }
}
