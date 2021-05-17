@ModelType IEnumerable(Of VIAJEESTELAR_MVC.Cliente)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_LayoutAdmin.vbhtml"
End Code

<h3>Administración de Clientes</h3>
<div class="d-flex justify-content-end my-3">
    <a href="/AdminCliente/Create" class="btn btn-success btn-sm">Crear Nuevo Cliente</a>
</div>
<table class="table table-striped">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </th>
        <th>
            Apellido Paterno
        </th>
        <th>
            Apellido Materno
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Edad)
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
                @Html.DisplayFor(Function(modelItem) item.ApellidoP)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.ApellidoM)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Edad)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Direccion)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Telefono)
            </td>
            <td>
                <a href="/AdminCliente/Edit/@item.ID_CLIENTE" class="btn btn-warning btn-sm"><i class="bi bi-pencil-square"></i></a>
                <a href="/AdminCliente/Delete/@item.ID_CLIENTE:" class="btn btn-danger btn-sm"><i class="bi bi-trash-fill"></i></a>
            </td>
        </tr>
    Next

</table>
