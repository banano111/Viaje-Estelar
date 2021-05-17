@ModelType IEnumerable(Of VIAJEESTELAR_MVC.Cliente)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ApellidoP)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ApellidoM)
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
        <th></th>
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
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ID_CLIENTE }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ID_CLIENTE }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ID_CLIENTE })
        </td>
    </tr>
Next

</table>
