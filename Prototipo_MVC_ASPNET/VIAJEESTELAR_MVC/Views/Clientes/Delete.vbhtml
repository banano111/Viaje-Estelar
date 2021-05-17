@ModelType VIAJEESTELAR_MVC.Cliente
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
