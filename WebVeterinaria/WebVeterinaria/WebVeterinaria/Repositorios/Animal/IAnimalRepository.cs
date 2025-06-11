﻿using WebVeterinaria.Datos;
using WebVeterinaria.Datos.Clase;



namespace WebVeterinaria.Repositorios.Animal
{
    public interface IAnimalRepository
    {
        List<WebVeterinaria.Datos.Clase.Animal> ObtenerAnimales();
        WebVeterinaria.Datos.Clase.Animal ObtenerAnimal(int id);
        void Eliminar(WebVeterinaria.Datos.Clase.Animal animal);
        void Agregar(WebVeterinaria.Datos.Clase.Animal animal);
        void Actualizar(WebVeterinaria.Datos.Clase.Animal animal);
    }

}
