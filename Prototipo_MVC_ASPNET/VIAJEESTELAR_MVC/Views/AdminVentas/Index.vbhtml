@ModelType IEnumerable(Of VIAJEESTELAR_MVC.Venta)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_LayoutAdmin.vbhtml"
End Code

<h3>Administración de Ventas</h3>

<table class="table table-striped mt-5">
    <tr>
        <th>
            ID Paquete Vendido
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Total)
        </th>
        <th>
            Fecha Venta
        </th>
        <th>
            ID Usuario Comprador
        </th>
        <th>
            Acciones
        </th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PaqueteVendido)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Total)
        </td>
        <td>
            @Convert.ToDateTime(item.FechaVenta).ToString("yyyy-MM-dd")
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UsuarioComprador)
        </td>
        <td>
            <a href="/AdminVentas/Delete/@item.ID_VENTA" class="btn btn-danger btn-sm"><i class="bi bi-trash-fill"></i></a>
        </td>
    </tr>
Next

</table>
