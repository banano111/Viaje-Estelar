@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated Then
    @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})
        @Html.AntiForgeryToken()
        @<div class="col-md-3 text-end">
            <!-- Example split danger button -->
            <div class="btn-group">
                <button type="button" class="btn btn-dark">@User.Identity.GetUserName()</button>
                <button type="button" class="btn btn-dark dropdown-toggle dropdown-toggle-split" data-bs-toggle="dropdown" aria-expanded="false">
                    <span class="visually-hidden">Toggle Dropdown</span>
                </button>
                <ul class="dropdown-menu">
                    <li><a class="dropdown-item" href="/AdminDestinos">Administracion</a></li>
                    <li><a class="dropdown-item" href="/Manage/ChangePassword">Cambiar Contraseña</a></li>
                    <li><hr class="dropdown-divider"></li>
                    <li><a class="dropdown-item" href="javascript:document.getElementById('logoutForm').submit()">Cerrar sesión</a></li>
                </ul>
            </div>
        </div>
    End Using
Else
    @<div class="col-md-3 text-end">
        @Html.ActionLink("Iniciar sesión", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "loginLink", .class = "btn btn-outline-dark me-2"})
        @Html.ActionLink("Registrarse", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink", .class = "btn btn-dark "})
    </div>  End If