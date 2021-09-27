function validateForm() {
    let n = document.forms["formulario"]["nombre"].value;
    let a = document.forms["formulario"]["apellido"].value;
    let e = document.forms["formulario"]["empresa"].value;
    if (n == ""|| a=="" || e=="") {
      alert("Por favor complete los campos");
      return false;
    }
  };
