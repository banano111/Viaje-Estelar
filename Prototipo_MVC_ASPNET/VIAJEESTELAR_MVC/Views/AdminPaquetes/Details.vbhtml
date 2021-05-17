@ModelType VIAJEESTELAR_MVC.Paquete
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_LayoutAdmin.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Paquete</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.NombrePaquete)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NombrePaquete)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DescripcionPaquete)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DescripcionPaquete)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UrlImagen)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UrlImagen)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Precio)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Precio)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Descuento)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Descuento)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PrecioFinal)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PrecioFinal)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Fecha)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Fecha)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID_PAQUETE }) |
    @Html.ActionLink("Back to List", "Index")
</p>
