using WebVeterinaria.Datos.Dtos;

namespace WebVeterinaria.Logica.MedicamentoLogic
{
    public interface IMedicamentoLogic
    {
        List<DtoMedicamento> ObtenerMedicamentos();
        DtoMedicamento ObtenerMedicamento(int id);
        bool EliminarMedicamento(int id);
        bool AgregarMedicamento(DtoMedicamento nuevoMedicamento);
        bool ActualizarMedicamento(int id, DtoMedicamento medicamentoDtos);
    }
}
