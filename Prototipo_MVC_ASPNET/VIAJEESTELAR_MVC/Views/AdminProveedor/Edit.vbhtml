@ModelType VIAJEESTELAR_MVC.Proveedor
@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_LayoutAdmin.vbhtml"
End Code

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    @<div class="container mt-5">
        <div class="row d-flex justify-content-center">
            <div class="col-6">
                <div class="card">
                    <div class="card-header h6">
                        Alta de Nuevo Proveedor
                    </div>
                    <div class="card-body">
                        <form>
                            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                            <div class="mb-3">
                                <label class="form-label">Nombre del Proveedor</label>
                                @Html.EditorFor(Function(model) model.Nombre, New With {.htmlAttributes = New With {.class = "form-control"}})
                                @Html.ValidationMessageFor(Function(model) model.Nombre, "", New With {.class = "text-danger"})
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputPassword1" class="form-label">RFC</label>
                                @Html.EditorFor(Function(model) model.RFC, New With {.htmlAttributes = New With {.class = "form-control"}})
                                @Html.ValidationMessageFor(Function(model) model.RFC, "", New With {.class = "text-danger"})
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputPassword1" class="form-label">Direccion</label>
                                @Html.EditorFor(Function(model) model.Direccion, New With {.htmlAttributes = New With {.class = "form-control"}})
                                @Html.ValidationMessageFor(Function(model) model.Direccion, "", New With {.class = "text-danger"})
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputPassword1" class="form-label">Telefono</label>
                                @Html.EditorFor(Function(model) model.Telefono, New With {.htmlAttributes = New With {.class = "form-control"}})
                                @Html.ValidationMessageFor(Function(model) model.Telefono, "", New With {.class = "text-danger"})
                            </div>
                            <button type="submit" class="btn btn-dark">Registrar</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
End Using