@ModelType VIAJEESTELAR_MVC.Paquete
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_LayoutAdmin.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
