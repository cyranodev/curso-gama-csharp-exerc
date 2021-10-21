using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Fastfood
{
	public class FuncionarioService
	{
		//private readonly Dictionary<string, Action<IFoodMaker>> ListaFuncionarios = new Dictionary<string, Action<IFoodMaker>>
		//{
		//	{ "Nugget", () => return new Assador() },
		//	{  "Hamburguer", () => return new Chapeiro() },
		//	{ "Fritas", () => return new Fritador() }
		//};

		public static IFoodMaker GetNew(Type comida) { return ListaFuncionarios[comida.Name]; }
	}

	//   public class FoodMakerFactory
	//{
	//	public static Assador Create(Fritas fritas)
	//	{
	//		return new Assador();
	//	}

	//	public static Chapeiro Create(Hamburguer fritas)
	//	{
	//		return new Assador();
	//	}
	//}
}