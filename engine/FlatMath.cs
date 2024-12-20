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
    // Clamp value between the min and max
    public static float Clamp(float value, float min, float max)
    {
      if (min == max)
      {
        return min;
      }

      if (min > max)
      {
        throw new ArgumentOutOfRangeException("Minimum is greater than the maximum.");
      }

      if (value < min)
      {
        return min;
      }

      if (value > max)
      {
        return max;
      }

      return value;
    }

    // Length/magnitude of a vector
    public static float Length(FlatVector v)
    {
      return MathF.Sqrt((v.X * v.X) + (v.Y * v.Y));
    }

    // Distance between points in space
    public static float Distance(FlatVector a, FlatVector b)
    {
      float dx = a.X - b.X;
      float dy = a.Y - b.Y;

      return MathF.Sqrt((dx * dx) + (dy * dy));
    }

    // Normalization of a vector
    public static FlatVector Normalize(FlatVector v)
    {
      float len = FlatMath.Length(v);
      float x = v.X / len;
      float y = v.Y / len;

      return new FlatVector(x, y);
    }

    // Dot product with two vectors
    public static float Dot(FlatVector a, FlatVector b)
    {
      /*
       * a · b = a.x × b.x + a.y × b.y
       * This is cool: https://www.falstad.com/dotproduct/
      */
      return ((a.X * b.X) + (a.Y * b.Y));
    }

    // Cross product with two vectors
    public static float Cross(FlatVector a, FlatVector b)
    {
      /*
       * 2D physics, so treat z as z = 0 plane:
       * c.x = 0
       * c.y = 0
       * c.z = a.x x b.y - a.y x b.x
       * This is also cool: https://www.geogebra.org/m/psMTGDgc
      */
      return ((a.X * b.Y) - (a.Y * b.X));
    }

    // Clamp value between the min and the max
    public static float Clamp(float value, float min, float max)
    {
      if (min == max)
      {
        return min;
      }

      if (min > max)
      {
        throw new ArgumentOutOfRangeException("Minimum is greater than the maximum.")
      }

      if (value < min)
      {
        return min;
      }

      if (value > max)
      {
        return max;
      }

      return value;
    }
  }
}