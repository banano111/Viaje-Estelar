@ModelType RegisterViewModel
@Code
    ViewBag.Title = "Registrarse"
End Code

@Using Html.BeginForm("Register", "Account", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
    @Html.AntiForgeryToken()

    @<text>
        @Html.ValidationSummary("", New With {.class = "text-danger"})
        <div Class="container mt-5">
            <div Class="row">
                <div Class="col">
                    <div Class="card shadow">
                        <div Class="card-body">
                            <div Class="row d-flex justify-content-evenly p-5">
                                <div Class="col-5 p-5 ms-5">
                                    <h2 Class="fw-bolder mb-5">Registro de Usuario</h2>
                                    <div Class="form-floating mb-4">
                                        @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control", .id = "floatingInput"})
                                        <Label for="floatingInput">Correo Electronico</Label>
                                    </div>
                                    <div Class="form-floating mb-5">
                                        @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control", .id = "floatingPassword"})
                                        <Label for="floatingPassword">Contraseña</Label>
                                    </div>
                                    <div Class="form-floating mb-5">
                                        @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control", .id = "floatingPassword"})
                                        <Label for="floatingPassword">Confirmar Contraseña</Label>
                                    </div>
                                    <Button Class="btn btn-dark">Registrarse</Button>
                                </div>
                                <div Class="col d-flex align-items-center justify-content-center ms-5">
                                    <img src="https://images.unsplash.com/photo-1500530855697-b586d89ba3ee?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=334&q=80" alt="">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </text>
End Using

@section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
