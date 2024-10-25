public class Presupuestos
{
    int idPresupuesto;
    string nombreDestinatario;
    List<PresupuestoDetalles> detalle;

    void MontoPresupuesto();
    void MontoPresupuestoConIva();
    void CantidadProductos();
}