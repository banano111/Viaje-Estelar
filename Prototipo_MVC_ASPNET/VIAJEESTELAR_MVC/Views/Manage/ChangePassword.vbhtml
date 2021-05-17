@ModelType ChangePasswordViewModel
@Code
    ViewBag.Title = "Cambiar contraseña"
End Code


@Using Html.BeginForm("ChangePassword", "Manage", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
    @Html.AntiForgeryToken()

    @<text>
        @Html.ValidationSummary("", New With {.class = "text-danger"})

        <div class="container mt-5">
            <div Class="row d-flex justify-content-center">
                <div Class="col-6">
                    <div Class="card">
                        <div Class="card-header h6">
                            Cambio de Contraseña
                        </div>
                        <div Class="card-body">
                            <form>
                                @Html.ValidationSummary(True, "", New With {.Class = "text-danger"})
                                <div Class="mb-3">
                                    <Label Class="form-label">Contraseña Anterior</Label>
                                    @Html.PasswordFor(Function(m) m.OldPassword, New With {.class = "form-control"})
                                </div>
                                <div Class="mb-3">
                                    <Label for="exampleInputPassword1" class="form-label">Nueva Contraseña</Label>
                                    @Html.PasswordFor(Function(m) m.NewPassword, New With {.class = "form-control"})
                                </div>
                                <div Class="mb-3">
                                    <Label for="exampleInputPassword1" class="form-label">Confirmar Contraseña</Label>
                                    @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
                                </div>
                                
                                <Button type = "submit" Class="btn btn-dark">Cambiar Contraseña</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </text>
End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section