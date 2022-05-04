namespace EquitableDemoNS;
struct StudentStruct {
  public string IIN { get; set; }
  public string LastName { get; set; }
  public int Age { get; set; }


  public static bool operator ==(StudentStruct s1, StudentStruct s2) {
    return s1.IIN == s2.IIN && s1.LastName == s2.LastName && s1.Age == s1.Age;
  }

  public static bool operator !=(StudentStruct s1, StudentStruct s2) {
    return !(s1 == s2);
  }
}

