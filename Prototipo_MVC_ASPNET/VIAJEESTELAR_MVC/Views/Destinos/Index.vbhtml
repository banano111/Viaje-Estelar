@ModelType IEnumerable(Of VIAJEESTELAR_MVC.Destinos)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container mb-5">
    <div class="row px-5">
        <div class="col bg-destinos d-flex align-items-center justify-content-center">
            <p class="display-5 text-white fw-bolder">Destinos</p>
        </div>
    </div>
</div>

<div class="container vh-100">
    <div class="row px-5 row-cols-3 destination-row d-flex justify-content-center">
        @For Each item In Model
            @<div Class="col h-100 d-flex justify-content-center mb-5">
                <div Class="card shadow" style="width: 17rem; height: 200px;">
                    <img src = "@item.UrlImagen" Class="card-img-top" alt="...">
                    <div Class="card-body shadow">
                        <h5 Class="card-title">@Html.DisplayFor(Function(modelItem) item.NombreDestino)</h5>
                        <p Class="card-text">@Html.DisplayFor(Function(modelItem) item.DescripcionDestino)</p>
                        <a href = "#" Class="btn btn-outline-dark">Descubrir</a>
                    </div>
                </div>
            </div>
        Next
    </div>
</div>

