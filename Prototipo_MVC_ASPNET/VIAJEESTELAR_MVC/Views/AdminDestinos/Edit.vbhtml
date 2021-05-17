@ModelType VIAJEESTELAR_MVC.Destino
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
                        Edición de Destino
                    </div>
                    <div class="card-body">
                        <form>
                            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                            <div class="mb-3">
                                <label class="form-label">Nombre del Destino</label>
                                @Html.EditorFor(Function(model) model.NombreDestino, New With {.htmlAttributes = New With {.class = "form-control"}})
                                <div class="form-text">Nombre del Pais A Registrar</div>
                                @Html.ValidationMessageFor(Function(model) model.NombreDestino, "", New With {.class = "text-danger"})
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputPassword1" class="form-label">Descripcion</label>
                                @Html.EditorFor(Function(model) model.DescripcionDestino, New With {.htmlAttributes = New With {.class = "form-control"}})
                                @Html.ValidationMessageFor(Function(model) model.DescripcionDestino, "", New With {.class = "text-danger"})
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputPassword1" class="form-label">URL De la Imagen</label>
                                @Html.EditorFor(Function(model) model.UrlImagen, New With {.htmlAttributes = New With {.class = "form-control"}})
                                <div class="form-text">URL De la Imagen a Registrar en el Destino</div>
                                @Html.ValidationMessageFor(Function(model) model.UrlImagen, "", New With {.class = "text-danger"})
                            </div>
                            <button type="submit" class="btn btn-dark">Registrar</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
End Using