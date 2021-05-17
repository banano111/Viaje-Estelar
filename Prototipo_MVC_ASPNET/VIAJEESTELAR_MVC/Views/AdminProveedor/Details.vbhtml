@ModelType VIAJEESTELAR_MVC.Proveedor
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_LayoutAdmin.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Proveedor</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.RFC)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RFC)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Direccion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Telefono)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Telefono)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID_PROVEEDOR }) |
    @Html.ActionLink("Back to List", "Index")
</p>
