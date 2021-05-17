@ModelType VIAJEESTELAR_MVC.Venta
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_LayoutAdmin.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Venta</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.PaqueteVendido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PaqueteVendido)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Total)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Total)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaVenta)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaVenta)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UsuarioComprador)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UsuarioComprador)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID_VENTA }) |
    @Html.ActionLink("Back to List", "Index")
</p>
