using Gama.Locadora.Shared.Entities;

namespace Gama.Fastfood
{
    public abstract class AFuncionario<TComida> : Entity, IFoodMaker<TComida> where TComida : AComida, new()
    {
        public TComida FazerComida()
        {
            return new TComida();
        }
    }
}