using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace AdvancementsGenerator
{
	using SimplexNoise;

	internal static class ExtraFunction
	{
		public static IList<T> RandomArray<T>(this IList<T> array)
		{
			var _array = array.ToArray();
			_array.Select(x => Guid.NewGuid()).ToArray();
			return _array;

		}

		public static string SolveArray()
		{
			return "Hello World!";
		}
        
	}

	internal class BerlinNoise
	{
		float[,] map = Noise.Calc2D(20, 20, 3.5f);

	}
}
