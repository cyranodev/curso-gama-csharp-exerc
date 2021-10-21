namespace Gama.Fastfood
{
    public interface IFoodMaker<TComida> where TComida : AComida
    {
        TComida FazerComida();
    }
}