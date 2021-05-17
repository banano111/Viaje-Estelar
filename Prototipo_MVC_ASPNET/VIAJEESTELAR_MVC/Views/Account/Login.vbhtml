@ModelType LoginViewModel
@Code
    ViewBag.Title = "Iniciar sesión"
End Code

<div class="container mt-5">
    <div class="row">
        <div class="col">
            <div class="card shadow">
                <div class="card-body">
                    <div class="row d-flex justify-content-evenly p-5">
                        <div class="col-5 d-flex align-items-center justify-content-center">
                            <img src="https://images.unsplash.com/photo-1516483638261-f4dbaf036963?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=333&q=80" alt="">
                        </div>
                        <div class="col-4 p-5">
                            @Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                                @Html.AntiForgeryToken()
                                @<text>
                                    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                                    <h2 class="fw-bolder mb-5">Inicio de Sesión</h2>
                                    <div class="form-group mb-4">
                                        @Html.LabelFor(Function(m) m.Email, New With {.class = "form-label"})
                                        @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                                        @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-danger"})
                                    </div>
                                    <div class="form-group mb-5">
                                        @Html.LabelFor(Function(m) m.Password, New With {.class = "form-label"})
                                        @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                                        @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "text-danger"})
                                    </div>
                                    <input type="submit" value="Iniciar sesión" class="btn btn-dark" />
                                </text>
                            End Using
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section

