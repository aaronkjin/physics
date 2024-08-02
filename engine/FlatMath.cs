/* 
 * Class for basic vector math operations.
 *
 * Includes methods for length,
 * distance, normalization, dot
 * product, and cross product.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
  public static class FlatMath
  {
    // Length/magnitude of a vector
    public static float Length(FlatVector v)
    {
      return MathF.Sqrt((v.X * v.X) + (v.Y * v.Y));
    }

#if false
    // Distance between points in space
    public static float Distance(FlatVector a, FlatVector b)
    {

    }


    // Normalization of a vector
    public static FlatVector Normalize(FlatVector v)
    {

    }

    // Dot product with two vectors
    public static float Dot(FlatVector a, FlatVector b)
    {

    }

    // Cross product with two vectors
    public static float Cross(FlatVector a, FlatVector b)
    {

    }
#endif
  }
}