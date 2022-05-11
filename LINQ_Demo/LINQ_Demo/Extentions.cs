namespace StudentsAndGroupsNS;
static class Extentions {

  public static int NthIndexOf(this string s, char c, int occurence) {
    //https://stackoverflow.com/questions/39209729/indexof-n-th-character-of-that-type
    if (s == null) throw new ArgumentNullException(nameof(s));
    if (occurence <= 0) return -1;

    int i = -1, o = 0;
    do {
      i = s.IndexOf(c, i + 1);
      o++;
    } while (i >= 0 && o < occurence);

    return i;
  }

}

