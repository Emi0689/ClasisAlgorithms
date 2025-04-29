using DesignPatterns.Composite;
using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Text;

namespace DesignPatterns.Adpater_Wrapper
{
    //El patrón Adapter(también llamado Wrapper) permite que dos interfaces incompatibles trabajen juntas.
    //El adaptador convierte la interfaz de una clase en otra que el cliente espera.
    //Se usa, por ejemplo, cuando tienes una clase existente que no puedes modificar, pero necesitas que "parezca" de otro tipo.

    //Supongamos que tienes un sistema que espera leer datos de una "fuente de datos", 
    //pero sólo tienes una vieja clase de "archivo de texto" que no cumple con esa interfaz.

    // Interfaz esperada
    public interface IDataSource
    {
        string ReadData();
    }

    // Clase existente incompatible
    public class TextFileReader
    {
        public string GetFileContent()
        {
            return "Contenido del archivo de texto.";
        }
    }

    // Adaptador
    public class TextFileAdapter : IDataSource
    {
        private readonly TextFileReader _textFileReader;

        public TextFileAdapter(TextFileReader textFileReader)
        {
            _textFileReader = textFileReader;
        }

        public string ReadData()
        {
            // Adaptamos la llamada
            return _textFileReader.GetFileContent();
        }
    }
    class ProgramAdapter
    {
        static void Main(string[] args)
        {
            TextFileReader oldTextFile = new TextFileReader();
            IDataSource adaptedSource = new TextFileAdapter(oldTextFile);

            // El cliente puede usar IDataSource sin saber que es un TextFileReader
            Console.WriteLine(adaptedSource.ReadData());
        }
    }
}
