function getName() {
  debugger;
  let nombre = document.getElementsByClassName('inputForm')[0].value;
  let apellido = document.getElementsByClassName('inputForm')[1].value;

  alert(`Hola ${nombre} ${apellido}, gracias por llenar el formulario!`);
}
