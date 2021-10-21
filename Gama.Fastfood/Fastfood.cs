namespace Gama.Fastfood
{
    public class Fastfood<TComida> : IFoodProvider<TComida> where TComida : AComida
    {
        public Fastfood()
        {
            Funcionario = Services.GetNewFuncionario<TComida>();
        }

        private IFoodMaker<TComida> Funcionario { get; }

        public TComida ServirComida()
        {
            return Funcionario.FazerComida();
        }
    }
}