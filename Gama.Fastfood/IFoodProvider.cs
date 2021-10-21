namespace Gama.Fastfood
{
    public interface IFoodProvider<TComida> where TComida : AComida
    {
        TComida ServirComida();
    }
}