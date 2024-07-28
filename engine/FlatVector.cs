/* 
 * Lightweight, high-performing vector class.
 *
 * Building block of physics engine,
 * Representing all objects on a 2-dimensional grid.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
  public readonly struct FlatVector
  {
    public readonly float X;
    public readonly float Y;

    public static readonly FlatVector Zero = new FlatVector(0f, 0f);

    // Constructor for vector struct
    public FlatVector (float x, float y)
    {
      this.X = x;
      this.Y = y;
    }

    // Vector addition
    public static FlatVector operator +(FlatVector a, FlatVector b)
    {
      return new FlatVector(a.X + b.X, a.Y + b.Y);
    }

    // Vector subtraction
    public static FlatVector operator -(FlatVector a, FlatVector b)
    {
      return new FlatVector(a.X - b.X, a.Y - b.Y);
    }

    // Vector negation
    public static FlatVector operator -(FlatVector v)
    {
      return new FlatVector(-v.X, -v.Y);
    }

    // Vector multiplication (with a scalar)
    public static FlatVector operator *(FlatVector v, float s) 
    {
      return new FlatVector(v.X * s, v.Y * s);
    }

    // Vector division (with a scalar)
    public static FlatVector operator /(FlatVector v, float s) 
    {
      return new FlatVector(v.X / s, v.Y / s);
    }

    // Check equality between vectors
    public bool Equal(FlatVector other)
    {
      return this.X == other.X && this.Y == other.Y;
    }

    // Pattern-match and cast a vector
    public override bool Equals(object obj)
    {
      if (obj is FlatVector other)
      {
        return this.Equal(other);
      }
      return base.Equals(obj);
    }
  }
}