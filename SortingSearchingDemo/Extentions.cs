namespace StudentsNS;
public static class ArrayListExtensions {
  public static int BinarySearch<T>(this T[] array, T item, Func<T, T, int> compare) {
    return Array.BinarySearch(array, item, new ComparisonComparer<T>(compare));
  }


  public static int BinarySearch<T>(this List<T> list, T item, Func<T, T, int> compare) {
    return list.BinarySearch(item, new ComparisonComparer<T>(compare));
  }
}



public class ComparisonComparer<T> : IComparer<T> {
  private readonly Comparison<T> _comparison;

  public ComparisonComparer(Func<T, T, int> compare) {
    if (compare == null) {
      throw new ArgumentNullException("comparison");
    }
    _comparison = new Comparison<T>(compare);
  }

  public int Compare(T x, T y) {
    return _comparison(x, y);
  }
}

