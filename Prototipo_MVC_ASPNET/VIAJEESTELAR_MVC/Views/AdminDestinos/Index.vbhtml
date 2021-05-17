@ModelType IEnumerable(Of VIAJEESTELAR_MVC.Destino)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_LayoutAdmin.vbhtml"
End Code

<h3>Administración de Destinos</h3>
<div class="d-flex justify-content-end my-3">
    <a href="/AdminDestinos/Create" class="btn btn-success btn-sm">Crear Nuevo Destino</a>
</div>
<table class="table table-striped table-hover">
    <thead>
        <tr>
            <th scope="col">
                Nombre del Destino
            </th>
            <th scope="col">
                Descripción del Destino
            </th>
            <th scope="col">
                Imagen
            </th>
            <th>
                Acciones
            </th>
        </tr>
    </thead>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NombreDestino)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DescripcionDestino)
        </td>
        <td>
            <img src="@item.UrlImagen" alt="Imagen Destino" width="100px" height="100px" />
        </td>
        <td>
            <a href="/AdminDestinos/Edit/@item.ID_DESTINO" class="btn btn-warning btn-sm"><i class="bi bi-pencil-square"></i></a>
            <a href="/AdminDestinos/Delete/@item.ID_DESTINO" class="btn btn-danger btn-sm"><i class="bi bi-trash-fill"></i></a>
        </td>
    </tr>
Next

</table>
