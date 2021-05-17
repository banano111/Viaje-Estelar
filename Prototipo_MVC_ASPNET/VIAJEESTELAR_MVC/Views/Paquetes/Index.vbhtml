@ModelType IEnumerable(Of VIAJEESTELAR_MVC.Paquetes)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container mb-5">
    <div class="row px-5">
        <div class="col bg-paquetes d-flex align-items-center justify-content-center">
            <p class="display-5 text-white fw-bolder">Paquetes</p>
        </div>
    </div>
</div>
<div class="container mt-5">
    <div class="row d-flex flex-column">
        @For Each item In Model
            @<div class="col d-flex justify-content-center mb-4">
                <div class="card mb-3 shadow card-paquetes overflow-hidden">
                    <div class="row g-0">
                        <div class="col-md-4">
                            <img class="img-fluid"
                                 src="@item.UrlImagen"
                                 alt="Imagen de Paquete">
                        </div>
                        <div class="col-md-5">
                            <div class="card-body">
                                <h5 class="card-title">@item.NombrePaquete</h5>
                                <p class="card-text">@item.DescripcionPaquete</p>
                            </div>
                        </div>
                        <div class="col-md-3 border-gray-200 border-start">
                            <div class="mt-2">
                                <button class="btn btn-warning btn-sm">-@item.Descuento%</button>
                            </div>
                            <div class="mt-4 ms-3 text-start ">
                                <p class="fw-light datosprecio-card text-muted">Precio por Noche Desde:</p>
                                <p class="fw-normal precio-card text-muted">
                                    MXN$@Convert.ToInt32(item.PrecioFinal)
                                    <span class="fw-normal precioch-card text-muted text-decoration-line-through">MXN$@Convert.ToInt32(item.Precio)</span>
                                </p>
                                <p class="fw-normal datosprecio-card text-muted">Fecha de Salida <br>@Format(item.Fecha, "dd/MM/yyyy")</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        Next
    </div>
</div>
