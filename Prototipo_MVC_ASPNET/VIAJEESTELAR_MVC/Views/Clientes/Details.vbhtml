@ModelType VIAJEESTELAR_MVC.Cliente
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Cliente</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ApellidoP)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ApellidoP)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ApellidoM)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ApellidoM)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Edad)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Edad)
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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID_CLIENTE }) |
    @Html.ActionLink("Back to List", "Index")
</p>
