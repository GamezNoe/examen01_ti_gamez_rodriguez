using System;
using examen01_ti_gamez_rodriguez.RRGPModels;
using examen01_ti_gamez_rodriguez.RRGPServices;

class Program
{
    static void Main()
    {
        var areaCalc = new RRGPAreaCalculator();
        var volumeCalc = new RRGPVolumeCalculator();
        var printer = new RRGPGeometryPrinter(areaCalc, volumeCalc);

        var circle = new RRGPCircle(5);     // Área
        var square = new RRGPSquare(4);     // Área
        var sphere = new RRGPSphere(3);     // Área y volumen
        var cube = new RRGPCube(2);         // Área y volumen

        printer.Area(circle, "Círculo");
        printer.Area(square, "Cuadrado");

        printer.Area(sphere, "Esfera");
        printer.Volumen(sphere, "Esfera");

        printer.Area(cube, "Cubo");
        printer.Volumen(cube, "Cubo");
    }
}