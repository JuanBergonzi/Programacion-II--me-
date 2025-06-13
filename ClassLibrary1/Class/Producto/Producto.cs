namespace Class
{
    public class Producto
    {
        public int CodProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        
        public void DarDeAltaProducto()
        {
            CodProducto = CodProducto++;
            Nombre = Nombre;
            Descripcion = Descripcion;
            Stock = Stock;
        }
    }
}
