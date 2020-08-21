var circulo = document.getElementById('circulo');
var cuadrado = document.getElementById('cuadrado');
var limpiar = document.getElementById('limpiar');

circulo.addEventListener('click', () => {
  document.getElementById('circulo').classList.add('circuloCambio');
});

cuadrado.addEventListener('click', () => {
  document.getElementById('cuadrado').classList.add('cuadradoCambio');
});

limpiar.addEventListener('click', () => {
  document.getElementById('circulo').classList.remove('circuloCambio');
  document.getElementById('cuadrado').classList.remove('cuadradoCambio');
});
