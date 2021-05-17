@ModelType VIAJEESTELAR_MVC.Paquete
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
                        Edición de Paquetes
                    </div>
                    <div class="card-body">
                        <form>
                            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                            <div class="mb-3">
                                <label class="form-label">Nombre del Paquete</label>
                                @Html.EditorFor(Function(model) model.NombrePaquete, New With {.htmlAttributes = New With {.class = "form-control"}})
                                <div class="form-text">Nombre del Paquete A Registrar</div>
                                @Html.ValidationMessageFor(Function(model) model.NombrePaquete, "", New With {.class = "text-danger"})
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputPassword1" class="form-label">Descripcion</label>
                                @Html.EditorFor(Function(model) model.DescripcionPaquete, New With {.htmlAttributes = New With {.class = "form-control"}})
                                @Html.ValidationMessageFor(Function(model) model.DescripcionPaquete, "", New With {.class = "text-danger"})
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputPassword1" class="form-label">URL De la Imagen</label>
                                @Html.EditorFor(Function(model) model.UrlImagen, New With {.htmlAttributes = New With {.class = "form-control"}})
                                <div class="form-text">URL De la Imagen a Registrar en el Destino</div>
                                @Html.ValidationMessageFor(Function(model) model.UrlImagen, "", New With {.class = "text-danger"})
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputPassword1" class="form-label">Precio</label>
                                @Html.EditorFor(Function(model) model.Precio, New With {.htmlAttributes = New With {.class = "form-control"}})
                                @Html.ValidationMessageFor(Function(model) model.Precio, "", New With {.class = "text-danger"})
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputPassword1" class="form-label">Descuento</label>
                                @Html.EditorFor(Function(model) model.Descuento, New With {.htmlAttributes = New With {.class = "form-control"}})
                                @Html.ValidationMessageFor(Function(model) model.Descuento, "", New With {.class = "text-danger"})
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputPassword1" class="form-label">Precio Final</label>
                                @Html.EditorFor(Function(model) model.PrecioFinal, New With {.htmlAttributes = New With {.class = "form-control"}})
                                @Html.ValidationMessageFor(Function(model) model.PrecioFinal, "", New With {.class = "text-danger"})
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputPassword1" class="form-label">Fecha</label>
                                @Html.EditorFor(Function(model) model.Fecha, New With {.htmlAttributes = New With {.class = "form-control"}})
                                @Html.ValidationMessageFor(Function(model) model.Fecha, "", New With {.class = "text-danger"})
                            </div>
                            <button type="submit" class="btn btn-dark">Registrar</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>  End Using