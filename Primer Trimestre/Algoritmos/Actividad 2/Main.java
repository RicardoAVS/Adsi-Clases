package com.ricavs;

import java.text.NumberFormat;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);



        /*
         Ejercicio 2 clase del dia 18 Marzo
         */

        double valorCompra, valorDescuento, totalDescuentoClientes = 0d, totalPagadoClientes = 0d;
        double sumaDescuento10 = 0.0d, sumaDescuento15 = 0.0d, sumaDescuento20 = 0.0d, sumaDescuento25 = 0.0d, sumaDescuento30 = 0.0d, sumaDescuento35 = 0.0d;
        int contador35Porciento = 0, contador30Porciento = 0, contador25Porciento = 0, contador20Porciento = 0, contador15Porciento = 0, contador10Porciento = 0, contadorNoDescuento = 0;
        char continuar = 'S';

        // Preguntar si desea seguir ingresando datos
        while (continuar != 'N') {
            System.out.print("Ingrese el valor de la compra: ");
            valorCompra = scanner.nextLong();

            while (valorCompra <= 0) {
                System.out.println("Monto invalido, el valor de la compra debe ser mayor a 0");
                System.out.print("Ingrese el valor de la compra: ");
                valorCompra = scanner.nextLong();
            }

            if (valorCompra > 1_000_000) {
                valorDescuento = (valorCompra * 0.35);
                valorCompra -= valorDescuento;
                sumaDescuento35 += valorDescuento;
                totalPagadoClientes += valorCompra;
                totalDescuentoClientes += valorDescuento;
                contador35Porciento++;

            } else if (valorCompra >= 800_000) {
                valorDescuento = (valorCompra * 0.30);
                valorCompra -= valorDescuento;
                sumaDescuento30 += valorDescuento;
                totalPagadoClientes += valorCompra;
                totalDescuentoClientes += valorDescuento;
                contador30Porciento++;

            } else if (valorCompra >= 500_000) {
                valorDescuento = (valorCompra * 0.25);
                valorCompra -= valorDescuento;
                sumaDescuento25 += valorDescuento;
                totalPagadoClientes += valorCompra;
                totalDescuentoClientes += valorDescuento;
                contador25Porciento++;

            } else if (valorCompra >= 300_000) {
                valorDescuento = (valorCompra * 0.20);
                valorCompra -= valorDescuento;
                sumaDescuento20 += valorDescuento;
                totalPagadoClientes += valorCompra;
                totalDescuentoClientes += valorDescuento;
                contador20Porciento++;

            } else if (valorCompra >= 100_000) {
                valorDescuento = (valorCompra * 0.15);
                valorCompra -= valorDescuento;
                sumaDescuento15 += valorDescuento;
                totalPagadoClientes += valorCompra;
                totalDescuentoClientes += valorDescuento;
                contador15Porciento++;

            } else if (valorCompra >= 50_000) {
                valorDescuento = (valorCompra * 0.10);
                valorCompra -= valorDescuento;
                sumaDescuento10 += valorDescuento;
                totalPagadoClientes += valorCompra;
                totalDescuentoClientes += valorDescuento;
                contador10Porciento++;

            } else {
                totalPagadoClientes += valorCompra;
                contadorNoDescuento++;

            }

            // Preguntar si se quiere seguir ingresando mas datos
            System.out.print("Ingresar nuevos datos [S/N]? ");
            continuar = scanner.next().charAt(0);
        }

        // Imprimir las estadisticas obtenidas
        System.out.println("Numero de clientes sin descuento " + contadorNoDescuento);
        System.out.println("Cantidad de clientes que obtuvieron un 35% descuento " + contador35Porciento);
        System.out.println("Cantidad de clientes que obtuvieron un 30% descuento " + contador30Porciento);
        System.out.println("Cantidad de clientes que obtuvieron un 25% descuento " + contador25Porciento);
        System.out.println("Cantidad de clientes que obtuvieron un 20% descuento " + contador20Porciento);
        System.out.println("Cantidad de clientes que obtuvieron un 15% descuento " + contador15Porciento);
        System.out.println("Cantidad de clientes que obtuvieron un 10% descuento " + contador10Porciento);
        System.out.println("Total descontado por el 35% " + sumaDescuento35);
        System.out.println("Total descontado por el 30% " + sumaDescuento30);
        System.out.println("Total descontado por el 25% " + sumaDescuento25);
        System.out.println("Total descontado por el 20% " + sumaDescuento20);
        System.out.println("Total descontado por el 15% " + sumaDescuento15);
        System.out.println("Total descontado por el 10% " + sumaDescuento10);
        System.out.println("Total descontado a todos los clientes: " + totalDescuentoClientes);
        System.out.println("Total pagado por todos los clientes " + totalPagadoClientes);



        /*
         Ejercicio 1 clase del dia 17 de Marzo
         */
        long inversionSocioA, inversionSocioB, inversionSocioC, totalGanancias, totalInversion, reinversionAnual, gananciaAnual;
        final float PORCENTAJE_REINVERSION = 0.60f;

        // Pedir los datos al usuario con respecto a cuanto va a invertir cada socio
        System.out.print("Socio A - Ingrese cuanto capital desea invertir: ");
        inversionSocioA = scanner.nextLong();

        System.out.print("Socio B - Ingrese cuanto capital desea invertir: ");
        inversionSocioB = scanner.nextLong();

        System.out.print("Socio - C Ingrese cuanto capital desea invertir: ");
        inversionSocioC = scanner.nextLong();

        System.out.print("Ingrese el valor total de la ganancia anual: ");
        totalGanancias = scanner.nextLong();

        // Asegurarnos de que el monto que ingrese el usuario sea mayor a 0
        while ((inversionSocioA <= 0) || (inversionSocioB <= 0) || (inversionSocioC <= 0) || (totalGanancias <= 0)) {
            System.out.print("- Alguno de los montos ingresados no es valido\n" +
                    "- Ingrese un monto valido (mayor a 0)\n");

            System.out.print("Socio A - Ingrese cuanto capital desea invertir: ");
            inversionSocioA = scanner.nextLong();

            System.out.print("Socio B - Ingrese cuanto capital desea invertir: ");
            inversionSocioB = scanner.nextLong();

            System.out.print("Socio - C Ingrese cuanto capital desea invertir: ");
            inversionSocioC = scanner.nextLong();


            System.out.print("Ingrese el valor total de la ganancia anual: ");
            totalGanancias = scanner.nextLong();

        }

        // Calcular cuanto se va a reinvertir del capital anual generado
        reinversionAnual = (long) (totalGanancias * PORCENTAJE_REINVERSION);

        // Capital total anual generado
        gananciaAnual = totalGanancias - reinversionAnual;

        totalInversion = (inversionSocioA + inversionSocioB + inversionSocioC);

        // Cacular que porcentaje le corresponde a cada socio de acuerdo a su aporte
        float porcentajeParticipacionA = (float) ((inversionSocioA * 100) / totalInversion);
        float porcentajeParticipacionB = (float) ((inversionSocioB * 100) / totalInversion);
        float porcentajeParticipacionC = (float) ((inversionSocioC * 100) / totalInversion);

        // Calcular cuanto capital le corresponde a cada uno de los socios segun lo invertido
        long gananciaSocioA = (long) ((gananciaAnual * (porcentajeParticipacionA / 100)) * 0.4); // El 0.4 corresponde al 40% del valor de las ganancias que va a generar
        long gananciaSocioB = (long) (gananciaAnual * ((porcentajeParticipacionB / 100)) * 0.4);
        long gananciaSocioC = (long) (gananciaAnual * ((porcentajeParticipacionC / 100)) * 0.4);

        // Procedemos a realizar el calculo que reinvierte cada socio con respecto a su aporte inicial
        long reinversionAnualSocioA = (long) (reinversionAnual * (porcentajeParticipacionA / 100));
        long reinversionAnualSocioB = (long) (reinversionAnual * (porcentajeParticipacionB / 100));
        long reinversionAnualSocioC = (long) (reinversionAnual * (porcentajeParticipacionC / 100));

        // El 60% del total de lo que va a reinvertir cada socio
        long reinversionA60 = (long) (reinversionAnualSocioA * 0.6);
        long reinversionB60 = (long) (reinversionAnualSocioB * 0.6);
        long reinversionC60 = (long) (reinversionAnualSocioC * 0.6);

        // Averiguar el total invertido por cada socio despues de las ganancias
        long totalInvertidoSocioA = inversionSocioA + reinversionAnualSocioA;
        long totalInvertidoSocioB = inversionSocioB + reinversionAnualSocioB;
        long totalInvertidoSocioC = inversionSocioC + reinversionAnualSocioC;


        // Mostrar resultados en la consola
        System.out.println("Monto total invertido al momento de crear la empresa: " + NumberFormat.getCurrencyInstance().format(totalInversion) + " COP");
        System.out.println("Porcentaje de inversion de cada socio: ");
        System.out.println("Socio A: " + porcentajeParticipacionA + "%");
        System.out.println("Socio B: " + porcentajeParticipacionB + "%");
        System.out.println("Socio C: " + porcentajeParticipacionC + "%");
        System.out.println("60% de la ganancia: " + NumberFormat.getCurrencyInstance().format(reinversionAnual) + " COP");
        System.out.println("40% de la ganancia: " + NumberFormat.getCurrencyInstance().format(gananciaAnual) + " COP");

        System.out.println("60% del valor a reinvertir por el socio A " + NumberFormat.getCurrencyInstance().format(reinversionA60) + " COP");
        System.out.println("60% del valor a reinvertir por el  socio B " + NumberFormat.getCurrencyInstance().format(reinversionB60) + " COP");
        System.out.println("60% del valor a reinvertir por el  socio C " + NumberFormat.getCurrencyInstance().format(reinversionC60) + " COP");

        System.out.println("total invertido socio A " + NumberFormat.getCurrencyInstance().format(totalInvertidoSocioA) + " COP");
        System.out.println("total invertido socio B " + NumberFormat.getCurrencyInstance().format(totalInvertidoSocioB) + " COP");
        System.out.println("total invertido socio C " + NumberFormat.getCurrencyInstance().format(totalInvertidoSocioC) + " COP");

        System.out.println("40% del valor que la ganancia por utilidad que le corresponde al socio A " + NumberFormat.getCurrencyInstance().format(gananciaSocioA) + " COP");
        System.out.println("40% del valor que la ganancia por utilidad que le corresponde al socio B " + NumberFormat.getCurrencyInstance().format(gananciaSocioB) + " COP");
        System.out.println("40% del valor que la ganancia por utilidad que le corresponde al socio C " + NumberFormat.getCurrencyInstance().format(gananciaSocioC) + " COP");


    }
}