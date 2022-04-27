namespace InterfacesNS;

public interface IUndoable {
  void Undo();
}

public interface IRedoable : IUndoable {
  void Redo();
}



class ExtendingDemo : IRedoable {
  public void Redo() {
    WriteLine("Redoing ...");
  }

  public void Undo() {
    WriteLine("Undoung ...");
  }



  public static void Demo() {
    var ext = new ExtendingDemo();
    ext.Undo();
    ext.Redo();
    WriteLine();

    //or:
    IUndoable iUndo = ext;
    iUndo.Undo();

    IRedoable iRedo = ext;
    iRedo.Redo();
    //and:
    iRedo.Undo(); // !
  }
}

