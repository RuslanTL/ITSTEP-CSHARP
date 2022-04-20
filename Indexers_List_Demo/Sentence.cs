using static System.Console;

namespace DemoNS {
  class Sentence {
    string[] _words;


    public Sentence(string sentence) {
      _words = sentence.Split();
    }



    public string this[int wordNum] {  // indexer
      get { return _words[wordNum]; }
      set { _words[wordNum] = value; }
    }



    public static void Demo() {
      Sentence sent = new Sentence("HERE is Edward Bear, coming downstairs now, bump, bump, bump, on the back of his head, behind Christopher Robin");
      WriteLine(sent[2]);
      sent[2] = "Pooh";
      WriteLine(sent[2]);
    }

  }
}
