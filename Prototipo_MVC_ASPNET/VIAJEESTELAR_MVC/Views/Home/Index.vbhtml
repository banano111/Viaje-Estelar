@Code
    ViewData("Title") = "Home Page"
End Code

<div class="container vh-100 vw-100 py-3" id="mejorOpcion">
    <div class="row d-flex justify-content-around align-items-center mt-5">
        <div class="col p-5">
            <h1 class="display-5 fw-bold lh-1 mb-4">¿Porque somos tu mejor opción?</h1>
            <p class="lead justificado">
                Nuestros itinerarios fueron diseñados para hacer de su viaje una
                experiencia inolvidable. Brindamos el mejor servicio de viajes de manera completamente
                personalizada, con atención exclusiva para usted, apoyados en la tecnología más avanzada a su
                servicio.
            </p>
        </div>
        <div class="col-7 h-25">
            <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="carousel">
                <div class="carousel-indicators">
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0"
                            class="active" aria-current="true" aria-label="Slide 1"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1"
                            aria-label="Slide 2"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2"
                            aria-label="Slide 3"></button>
                </div>
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="https://images.unsplash.com/photo-1566371486490-560ded23b5e4?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80"
                             class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="https://images.unsplash.com/photo-1602088113235-229c19758e9f?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1347&q=80"
                             class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="https://images.unsplash.com/photo-1570368512653-7cea3a4a4fd2?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80"
                             class="d-block w-100" alt="...">
                    </div>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators"
                        data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators"
                        data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>
        </div>
    </div>
</div>

<div class="container">
    <div class="row">
        <div class="col"></div>
        <div class="col"></div>
        <div class="col"></div>
    </div>
</div>

<div class="container col-xxl-8 px-4 py-5 mb-5" id="valores">
    <div class="row flex-lg-row-reverse align-items-center g-5 py-5">
        <div class="col-10 col-sm-8 col-lg-6">
            <img src="https://images.squarespace-cdn.com/content/v1/5c49fd6055b02c13b37eee40/1555124629781-DXFR70Z6UJBLYNLG5215/ke17ZwdGBToddI8pDm48kJkt0yZW1VDvgZkwfnfTdARZw-zPPgdn4jUwVcJE1ZvWQUxwkmyExglNqGp0IvTJZUJFbgE-7XRK3dMEBRBhUpxAX5lZncSPKlFAJa5Gf5A7WXqDqH49abszzJ_zjmwfYy9rVj7i6SbsZJPKxgo283U/valor-2-Respeto-fhadi.png?format=1000w" class="d-block mx-lg-auto img-fluid" alt="Bootstrap Themes" width="700" height="500" loading="lazy">
        </div>
        <div class="col-lg-6">
            <h1 class="display-5 fw-bold lh-1 mb-3">Nuestros Valores</h1>
            <p class="lead">
                Nuestros valores como empresa e individuos son
                Honestidad, Lealtad, Respeto, Pasión por los desafíos, Superación Constante y Creatividad.
            </p>
        </div>
    </div>
</div>

<div class="container vh-100 vw-100 mt-5 py-5" id="promociones">
    <h2 class="pb-2 border-bottom mt-3">Nuestras Mejores Promociones</h2>
    <div class="row mt-4">
        <div class="col-4 w-100 d-flex justify-content-center">
            <img class="imagen-promo"
                 src="https://cdn.hotsale.com.mx/uploads/megaofertas/448/loscabos-5ec73e5459f2d.jpg" alt="">
            <img class="imagen-promo"
                 src="https://cdn.hotsale.com.mx/uploads/megaofertas/448/holbox-2-hotsale-5ecd4ef7ba6e5.jpg"
                 alt="">
            <img class="imagen-promo"
                 src="https://cdn.hotsale.com.mx/uploads/megaofertas/448/playahotpaquete-5ec73eeb6032c.jpg"
                 alt="">
        </div>
    </div>
</div>

<div class="container vh-100">
    <div class="row d-flex justify-content-center align-items-center">
        <div class="col">
            <div class="mapouter"><div class="gmap_canvas"><iframe width="600" height="500" id="gmap_canvas" src="https://maps.google.com/maps?q=2880%20Broadway,%20New%20York&t=&z=13&ie=UTF8&iwloc=&output=embed" frameborder="0" scrolling="no" marginheight="0" marginwidth="0"></iframe><a href="https://123movies-to.org"></a><br>
            <style>
                .mapouter {
                    position: relative;
                    text-align: right;
                    height: 500px;
                    width: 600px;
                }
            </style><a href="https://www.embedgooglemap.net">google maps html generator</a>
            <style>
                .gmap_canvas {
                    overflow: hidden;
                    background: none !important;
                    height: 500px;
                    width: 600px;
                }
            </style></div></div>
        </div>
        <div class="col">
            <h1 class="display-4 fw-bold lh-1 mb-3">¡Encuentranos Aqui!</h1>
            <p class="col-lg-10 fs-4">Nos puedes encontrar en la ubicación marcada en el mapa para mayores informes o reservaciones de manera presencial.</p>
        </div>
    </div>
</div>

<div class="container col-xl-10 col-xxl-8 px-4 vh-100" id="contacto">
    <div class="row align-items-center g-5 py-5">
        <div class="col-lg-7 text-center text-lg-start">
            <h1 class="display-4 fw-bold lh-1 mb-3">¿Necesitas Ayuda?</h1>
            <p class="col-lg-10 fs-4">¿Necesitas ayuda con tus planes de viaje afectados por el COVID-19? El lugar indicado para contactarnos y recibir información sobre tu viaje es a través de este portal en línea. Para más información o más ayuda, envía un correo a viaje.estelar@OurProject.com o marca al numero 45-54445.</p>
        </div>
        <div class="col-10 mx-auto col-lg-5">
            <form class="p-5 border rounded-3 bg-light">
                <div class="form-floating mb-3">
                    <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com">
                    <label for="floatingInput">Correo Electronico de Contacto</label>
                </div>
                <div class="form-floating mb-3">
                    <textarea class="form-control" placeholder="Leave a comment here" id="floatingTextarea"></textarea>
                    <label for="floatingTextarea">Descripción</label>
                </div>
                <button class="w-100 btn btn-lg btn-primary" type="submit">Enviar</button>
                <hr class="my-4">
                <small class="text-muted">Al enviar este formulario aceptas nuestros terminos de uso.</small>
            </form>
        </div>
    </div>
</div>
