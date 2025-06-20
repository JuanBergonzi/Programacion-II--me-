﻿using AdmVeterinaria.Datos;



namespace AdmVeterinaria.Repositorios.Animal
{
    public interface IAnimalRepository
    {
        List<AdmVeterinaria.Datos.Clases.Animal> ObtenerAnimales();
        AdmVeterinaria.Datos.Clases.Animal ObtenerAnimal(int id);
        void Eliminar(AdmVeterinaria.Datos.Clases.Animal animal);
        void Agregar(AdmVeterinaria.Datos.Clases.Animal animal);
        void Actualizar(AdmVeterinaria.Datos.Clases.Animal animal);
    }

}
