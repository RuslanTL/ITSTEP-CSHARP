using System.Text;
namespace DemoNS;

public class Person {
  public string IIN;
  public string LastName;
  public int Age;
  public DateTime Birthday;
}

public class Binary_Person {
  public static void Demo() {
    //string fileBinName = @"C:\_0\persons.txt";
    string _fileBinName = @"persons.bin";
    int _bytesNameArrSize = 20;

    var _persons = new List<Person> {
        new Person { IIN = "111111111111", LastName = "Pooh", Birthday = new DateTime(2020, 1, 31), Age = 3,},
        new Person { IIN = "222222222222", LastName = "Тигра", Birthday = new DateTime(2020, 10, 1), Age = 2},
        new Person { IIN = "333333333333", LastName = "Piglet", Birthday = new DateTime(2020, 1, 10),Age = 1},
      };

    //writing binary file
    using (var file = new BinaryWriter(File.Open(_fileBinName, FileMode.Create))) {
      byte[] nameArr;
      foreach (var person in _persons) {
        file.Write(person.IIN);

        nameArr = Encoding.UTF8.GetBytes(person.LastName);
        Array.Resize(ref nameArr, _bytesNameArrSize);
        file.Write(nameArr);

        file.Write(person.Age);

        //can't!
        //file.Write(person.Birthday);

        byte[] birthdayArr = BitConverter.GetBytes(person.Birthday.ToBinary());
        file.Write(birthdayArr);
      }
    }


    //reading binary file from end!
    var stream = File.Open(_fileBinName, FileMode.Open);
    using (var file = new BinaryReader(stream)) {
      var person = new Person();
      int count = _persons.Count;
      long recordSize = stream.Length / _persons.Count;
      for (int i = 0; i < count; i++) {
        file.BaseStream.Position = recordSize * (count - 1 - i);
        person.IIN = file.ReadString();

        var nameArr = file.ReadBytes(_bytesNameArrSize);
        person.LastName = Encoding.UTF8.GetString(nameArr.TakeWhile(b => !b.Equals(0)).ToArray());

        person.Age = file.ReadInt32();

        var birthdayArr = file.ReadBytes(8);
        long nVal = BitConverter.ToInt64(birthdayArr, 0);
        person.Birthday = DateTime.FromBinary(nVal);

        WriteLine($"{person.IIN}\t{person.LastName}\t{person.Age}\t{person.Birthday}");
      }
    }
  }

}

