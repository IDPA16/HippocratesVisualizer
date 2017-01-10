using System;
using System.Collections.Generic;
using System.Linq;

namespace Hippocrates.Visualizer.Linq
{
  /// <summary>
  /// Source: http://themechanicalbride.blogspot.ch/2008/11/auto-sizing-canvas-for-silverlight-and.html
  /// Under the MS-PL License
  /// </summary>
  public static class EnumerableFunctions
  {
    /// <summary>
    /// Returns the maximum value or null if sequence is empty.
    /// </summary>
    /// <param name="that">The sequence to retrieve the maximum value from.
    /// </param>
    /// <returns>The maximum value or null.</returns>
    public static T? MaxOrNullable<T>(this IEnumerable<T> that) where T : struct, IComparable
    {
      var enumerable = that as IList<T> ?? that.ToList();
      if (!enumerable.Any())
      {
        return null;
      }
      return enumerable.Max();
    }

    /// <summary>
    /// Returns the minimum value or null if sequence is empty.
    /// </summary>
    /// <param name="that">The sequence to retrieve the minimum value from.
    /// </param>
    /// <returns>The minimum value or null.</returns>
    public static T? MinOrNullable<T>(this IEnumerable<T> that) where T : struct, IComparable
    {
      var enumerable = that as IList<T> ?? that.ToList();
      if (!enumerable.Any())
      {
        return null;
      }
      return enumerable.Min();
    }
  }
}