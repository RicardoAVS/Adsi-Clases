/* 5. Leer un vector de N elementos numéricos enteros y posteriormente: 
• Mostrar cuántas veces se repite el número 10.
• Sume los elementos de las posiciones pares.
• Muestre los elementos del vector empezando por el último elemento. 
*/

let array = [1, 10, 5, 4, 44, 10, 50, 100, 15, 32, 10];
let numDiezCount = 0;
let sumaPairIndex = 0;

for (let i = array.length; i >= 0; i++) {

  if (i == 10) {
    numDiezCount++;
  } else if (i >= 2 && i % 2 == 0) {
    sumaPairIndex += array[i];
  } 
    console.log(array[i]);
}

// 6. De los 50 elementos de un vector, muestre cuántos son: pares, impares, negativos y positivos. 

let array = [];
let parCount = 0;
let imparCount = 0;
let negativeNumCount = 0;
let positiveNumCount;

for (let i = 0; i < 5; i ++) {
  array.push(Number(prompt("Ingresa un numero #" + (i + 1) + " ")))
}

for (let i = 0; i < array.length; i++) {
  if (array[i] > 0) {
    positiveNumCount++;

    if (array[i] % 2 == 0) {
      parCount++;
    } else {
      imparCount++;
    } 

  } else if (array[i] < 0) {
    negativeNumCount++;

    if (array[i] % 2 == 0) {
      parCount++;
    } else {
      imparCount++;
    } 
  }
}

console.log("Cantidad numeros pares " + parCount);
console.log("Cantidad numeros impares " + imparCount);
console.log("Cantidad numeros positivos " + positiveNumCount);
console.log("Cantidad numeros negativos " + negativeNumCount);

/* 7. En vector de 40 elementos numéricos llamado totales, se requiere ir sumando y mostrando cada elemento, 
    siempre y cuando sea mayor al primer elemento y menor al elemento 25.
    Finalmente, muestre el total de los elementos que fueron sumados. 
*/

/**
 * 8. Se tiene un vector con las notas de un grupo de 30 estudiantes. Hallar y mostrar la nota más
alta y la más baja, cuántas personas perdieron y la nota promedio del grupo.x`
 */

 
var arr = [1, 2, 6, 4, 10, 20, 3];
var aprobados = 0;
var reprobados = 0;
var notaMasAlta = 0;
var notaMasBaja = 0;

for (let i = 0; i < i++) {
  if (arr[i] > notaMasAlta) {
    notaMasAlta = arr[i];
  } else if (arr[i] < notaMasAlta && arr[i] < notaMasBaja) {
    notaMasBaja = arr[i];
  }
}

console.log(notaMasAlta + " nota mas alta");
console.log(notaMasBaja + " nota mas baja");

/**
 * Crear 2 vectores de "N" posiciones cada uno. Con el resultado de la multiplicación de elemento por elemento entre cada vector,
 *  formar otro arreglo; muestre posteriormente, los elementos del vector resultante.
 */

 var vector = [1, 2, 3, 4, 5,];
 var arr = [5, 4, 3, 2, 1];
 var potenciaArr = [];
 for (let i = 0; i < vector.length; i++) {
    potenciaArr.push(vector[i] * arr[i]);
 }

 for (let i = 0; i < vector.length; i++) {
   console.log(potenciaArr[i]);
 }

 /**
  * 10. Cargar 2 vectores, uno con los códigos de los estudiantes que perdieron C, 
  * el segundo con los códigos de los estudiantes que perdieron Java. 
  * Se pide crear otro arreglo formado por los códigos de los estudiantes que perdieron ambas materias. 
  * Mostrar el arreglo resultante.
  
  11. Lea un vector S de N elementos e inviértalo. Utilice otro Vector.

  */

  var perdieronC = [1, 2, 3, 4, 5, 6, 7];
  var perdieronJava = [8, 9, 10, 11, 12, 13];
  var perdieronAmbas = [];

  for (let i = 0; i < perdieronAmbas.length; i++) {
    perdieronAmbas.push(perdieronC[i]);
    perdieronAmbas.push(perdieronJava[i]);
  }

  for (let i = 0; i < perdieronAmbas.length; i++) {
    console.log(perdieronAmbas[i])
  }


  var vector = [1, 2, 3, 4, 5, 10, 11];
  var reverseVector = [];

for (let i = vector.length; i >= 0 ; i--) {
  reverseVector.push(vector[i]);
}

for (let i = 0; i < reverseVector.length; i++) {
  console.log(reverseVector[i])
}

/**
13.  13. Se tiene un vector de 365 elementos, cada elemento corresponde a la estación para ese día (V - Verano, I- Invierno, O - Otoño,
   P - Primavera). Calcular el número de días de verano durante el año.

14. Elabore un algoritmo que lea un vector de N elementos. Si el número de elementos es par intercambiar el elemento i-ésimo por el elemento
 i-ésimo+1. Mostrar el vector final. Si el número de elementos es impar, 
 indicarlo en un mensaje que no es posible hacer el intercambio y forzar al usuario hasta que digite un número de elementos par.

15. Teniendo un vector de 144 elementos numéricos enteros diferentes, realice lo siguiente:
- Buscar el elemento mayor y en qué posición lo encontró.
 - Sumar los elementos almacenados en las posiciones pares y mostrar la suma. - 
 Buscar cuántos elementos del vector son mayores de 80 y menores de 120. - 
 Hallar cuántos elementos del vector son múltiplos de 7. 
 - Mostrar los elementos del vector de forma inversa.

16. Se tiene un vector de 125 elementos con valores numéricos, realice lo siguiente:
- Hallar y mostrar el valor promedio del vector. -
  Leer un valor x y buscar en que posición del vector se encuentra. 
- Llene un vector con los elementos de las posiciones impares. 
- Busque cuántos elementos del vector son múltiplos de 3 y positivos.
 */



 // 14 TODO

var vector = [1, 2, 3, 4];
var nuevoVector = [];

var numero = Number(prompt("Ingresa un numero "));

while (numero % 2 == 0) {

  for (let i = 0; i < daysInYear.length; i++) {

    if (i == (vector.length - 1)) {
      nuevoVector[i] = vector[0];
    } else {
      nuevoVector[i] = vector[i + 1];
    }

  }

  console.log(" *** Resultado final del vector ***")
  for (let i = 0; i < vector.length; i++) {
    console.log(nuevoVector[i])
  }
}


 // 16
 var arr = [1, 2, 3, 4, 5];
 var newArr = [];
 for (let i = 0; i < daysInYear.length; i ++) {
   daysInYear[i] = daysInYear[i + 1];
 }

 for (let i = 0; i < daysInYear.length; i++) {
   console.log(daysInYear[i])
 }

var vector = [];
var vectorImpar = [];
var suma = 0;
var promedio = 0;
var multiplosTresCount = 0;

for (var i = 0; i < 126; i++) {
  var numeroAlAzar = Math.floor(Math.random() * 1000);
  vector.push(numeroAlAzar)

  if (i % 2 == 1) {
    vectorImpar.push(numeroAlAzar)
  }
}

var numero = Number(prompt("Que numero quiere buscar: "))
var posicionNumero = -1;

for (let i = 0; i < vector.length; i++) {
  suma += vector[i];

  if (vector[i] % 3 == 0) {
    multiplosTresCount++;
  }

  if (vector[i] == numero) {
    posicionNumero = i;
  }
}

promedio = suma / (vector.length);
console.log("El promedio total del vector es " + promedio)

if (posicionNumero != 1) {
  console.log("El numero se encuentra en la posicion " + i)
} else {
  console.log("El numero no se encuentra en el vector ");
}

console.log("La cantidad de numeros multiplos de 3 es " + multiplosTresCount);

// 15 

var randomArray = [1, 5, 3, 10, 100, 40, 77, 33, 599, 329, 70, 140, 7, 118, 90]; // 125 numeros no repetitivos
var highestNum = 0;
var pairIndexSum = 0;
var indexHighestNum = 0;
var higher80lower120 = 0;
var mult7Count = 0;

for (let i = randomArray.length; i >= 0; i--) {

  if (i % 2 == 0) {
    pairIndexSum += randomArray[i];
  } else if (randomArray[i] % 7 == 0) {
    mult7Count++;
  }

  if (randomArray[i] > highestNum) {
    highestNum = randomArray[i];
    indexHighestNum = i;

    if (randomArray[i] > 80 && randomArray[i] < 120) {
      higher80lower120++;
    }
  }

  console.log(randomArray[i]);
}

console.log("El numero con el valor mayor es " + highestNum + " Se encuentra en la posicion " + indexHighestNum + " del vector");
console.log("La suma de los numeros en las posiciones pares del vector es de  " + pairIndexSum);
console.log("Cantidad de numeros mayores a 80 y menores a 120: " + higher80lower120);
console.log("Cantidad de numeros multiplos de 7: " + mult7Count);
