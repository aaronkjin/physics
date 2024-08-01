/*
 * Converts FlatVectors to MonoGame
 * vectors, and vice versa
*/

using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

using engine;

namespace tests
{
  public class FlatConverter
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 ToVector2(FlatVector v)
    {
      return new Vector2(v.X, v.Y);
    }
  }
}