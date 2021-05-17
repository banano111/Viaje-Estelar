@ModelType VIAJEESTELAR_MVC.Destino
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_LayoutAdmin.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Destino</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.NombreDestino)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NombreDestino)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DescripcionDestino)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DescripcionDestino)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UrlImagen)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UrlImagen)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID_DESTINO }) |
    @Html.ActionLink("Back to List", "Index")
</p>
