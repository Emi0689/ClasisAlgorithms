using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    //El patrón Builder se usa para construir objetos complejos paso a paso,
    //separando el proceso de construcción de la representación final.
    //Es muy útil cuando un objeto tiene muchas partes opcionales o configuraciones,
    //y no queremos un constructor enorme o con demasiados parámetros (lo que se llama el constructor telescópico).

    public class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; }
        public bool HasSSD { get; set; }

        public override string ToString()
        {
            return $"CPU: {CPU}, GPU: {GPU}, RAM: {RAM}GB, SSD: {(HasSSD ? "Sí" : "No")}";
        }
    }

    public class ComputerBuilder
    {
        private readonly Computer _computer = new Computer();

        public ComputerBuilder SetCPU(string cpu)
        {
            _computer.CPU = cpu;
            return this;
        }

        public ComputerBuilder SetGPU(string gpu)
        {
            _computer.GPU = gpu;
            return this;
        }

        public ComputerBuilder SetRAM(int ram)
        {
            _computer.RAM = ram;
            return this;
        }

        public ComputerBuilder AddSSD()
        {
            _computer.HasSSD = true;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }

    class ProgramBuilder
    {
        static void Main(string[] args)
        {
            var builder = new ComputerBuilder();

            Computer gamingPc = builder
                .SetCPU("Intel i9")
                .SetGPU("RTX 4080")
                .SetRAM(32)
                .AddSSD()
                .Build();

            Console.WriteLine(gamingPc);

            // Otro ejemplo más simple:
            Computer officePc = builder
                .SetCPU("Intel i5")
                .SetRAM(16)
                .Build();

            Console.WriteLine(officePc);
        }
    }
}
