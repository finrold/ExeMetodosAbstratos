using ExeMetodosAbstratos.Entities;

namespace ExeMetodosAbstratos.Entities
{
    abstract class Imposto
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Imposto()
        {

        }

        protected Imposto(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Taxa();
    }
}
