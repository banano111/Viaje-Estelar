@ModelType IEnumerable(Of VIAJEESTELAR_MVC.Paquete)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_LayoutAdmin.vbhtml"
End Code

<h3>Administración de Paquetes</h3>
<div class="d-flex justify-content-end my-3">
    <a href="/AdminPaquetes/Create" class="btn btn-success btn-sm">Crear Nuevo Paquete</a>
</div>

<table class="table table-striped table-hover">
    <tr>
        <th>
            Nombre del Paquete
        </th>
        <th>
            Descripcion del Paquete
        </th>
        <th>
            Imagen
        </th>
        <th>
            Precio
        </th>
        <th>
            Descuento
        </th>
        <th>
            Precio Final
        </th>
        <th>
            Fecha
        </th>
        <th>
            Acciones
        </th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.NombrePaquete)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.DescripcionPaquete)
            </td>
            <td>
                <img src="@item.UrlImagen" alt="" width="100px" height="100px" />
            </td>
            <td>
                $@Html.DisplayFor(Function(modelItem) item.Precio)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Descuento)%
            </td>
            <td>
                $@Html.DisplayFor(Function(modelItem) item.PrecioFinal)
            </td>
            <td>
                @Convert.ToDateTime(item.Fecha).ToString("yyyy-MM-dd")
            </td>
            <td>
                <a href="/AdminPaquetes/Edit/@item.ID_PAQUETE" class="btn btn-warning btn-sm"><i class="bi bi-pencil-square"></i></a>
                <a href="/AdminPaquetes/Delete/@item.ID_PAQUETE" class="btn btn-danger btn-sm"><i class="bi bi-trash-fill"></i></a>
            </td>
        </tr>
    Next

</table>
