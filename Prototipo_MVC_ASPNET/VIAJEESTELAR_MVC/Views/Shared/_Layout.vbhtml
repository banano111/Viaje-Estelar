<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Viaje Estelar</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-wEmeIV1mKuiNpC+IOBjI7aAzPcEZeedi5yW5f2yOq55WWLwNGmvvx4Um1vskeMj0" crossorigin="anonymous">
    <link href="~/Content/site.css" rel="stylesheet" />
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <div class="container navbar-fixed-top" id="navbar">
        <header class="d-flex flex-wrap align-items-center justify-content-center justify-content-md-between py-3 mb-4 border-bottom">
            <div class="col-3">
                <img width="42px" height="42px"
                     src="~/assets/images/LogoViajeEstelar.png" />
                <span class="h5 ms-2">Viaje Estelar</span>
            </div>
            <ul class="nav col-12 col-md-auto mb-2 justify-content-center mb-md-0">
                <li><a href="/Home" class="nav-link px-2 link-secondary">Quienes Somos</a></li>
                <li><a href="/Paquetes" class="nav-link px-2 link-dark">Paquetes</a></li>
                <li><a href="/Destinos" class="nav-link px-2 link-dark">Destinos</a></li>
            </ul>
            
            @Html.Partial("_LoginPartial")
        
        </header>
    </div>
    
    <div class="container body-content">
        @RenderBody()
    </div>

    
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-p34f1UUtsS3wqzfto5wAAmdvj+osOnFyQFpp4Ua3gs/ZVWx6oOypYoCJhGGScy+8" crossorigin="anonymous"></script>
    @RenderSection("scripts", required:=False)
</body>
</html>
