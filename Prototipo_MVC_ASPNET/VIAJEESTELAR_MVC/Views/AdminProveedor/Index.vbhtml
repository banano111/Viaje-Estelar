@ModelType IEnumerable(Of VIAJEESTELAR_MVC.Proveedor)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_LayoutAdmin.vbhtml"
End Code

<h3>Administración de Proveedores</h3>
<div class="d-flex justify-content-end my-3">
    <a href="/AdminProveedor/Create" class="btn btn-success btn-sm">Crear Nuevo Proveedor</a>
</div>
<table class="table table-striped">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.RFC)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Telefono)
        </th>
        <th>
            Acciones
        </th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Nombre)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.RFC)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Direccion)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Telefono)
            </td>
            <td>
                <a href="/AdminProveedor/Edit/@item.ID_PROVEEDOR" class="btn btn-warning btn-sm"><i class="bi bi-pencil-square"></i></a>
                <a href="/AdminProveedor/Delete/@item.ID_PROVEEDOR:" class="btn btn-danger btn-sm"><i class="bi bi-trash-fill"></i></a>
            </td>
        </tr>
    Next

</table>
