using ExeMetodosAbstratos.Entities;

namespace ExeMetodosAbstratos.Entities
{
     class PessoaJuridica : Imposto
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;

        }

        public override double Taxa()
        {
            if(NumeroFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }


    }
}
