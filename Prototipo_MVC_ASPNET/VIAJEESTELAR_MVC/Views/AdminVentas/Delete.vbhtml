@ModelType VIAJEESTELAR_MVC.Venta
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_LayoutAdmin.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
