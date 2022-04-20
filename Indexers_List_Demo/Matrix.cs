using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNS {
  class Matrix {
    double[,] _matrix; 

    public Matrix(int nRow , int nCol) {
      _matrix = new double[nRow, nCol];
    }

    public double this[int iRow, int iCol] {
      get { return _matrix[iRow, iCol]; }
      set { _matrix[iRow, iCol] = value; }
    }

  }
}
