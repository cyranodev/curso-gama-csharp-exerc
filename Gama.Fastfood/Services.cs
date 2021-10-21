namespace Gama.Fastfood
{
    public static class Services
    {
        public static IFoodMaker<TComida> GetNewFuncionario<TComida>() where TComida : AComida
        {
            switch (typeof(TComida).Name)
            {
                case "Nugget":
                    return new Assador() as IFoodMaker<TComida>;

                case "Hamburguer":
                    return new Chapeiro() as IFoodMaker<TComida>;

                case "Fritas":
                    return new Fritador() as IFoodMaker<TComida>;

                default:
                    return null;
            }
        }
    }
}