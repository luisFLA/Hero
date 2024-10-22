// Archivo: Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear superpoderes con el constructor
        SuperPoder invulnerabilidad = new SuperPoder("Invulnerabilidad", "Capacidad de resistir daño físico extremo", 10);
        SuperPoder manipulacionEnergia = new SuperPoder("Manipulación de Energía", "Puede controlar y generar energía", 9);
        SuperPoder telepatia = new SuperPoder("Telepatía", "Capacidad de leer y controlar las mentes", 8);

        // Crear superhéroes con el constructor
        SuperHeroe thor = new SuperHeroe("Thor", "Thor Odinson", "Asgard", true, invulnerabilidad);
        SuperHeroe ironMan = new SuperHeroe("Iron Man", "Tony Stark", "Nueva York", false, manipulacionEnergia);
        SuperHeroe professorX = new SuperHeroe("Professor X", "Charles Xavier", "Nueva York", false, telepatia);

        // Mostrar la información de los superhéroes
        thor.MostrarInfo();
        ironMan.MostrarInfo();
        professorX.MostrarInfo();
    }
}
