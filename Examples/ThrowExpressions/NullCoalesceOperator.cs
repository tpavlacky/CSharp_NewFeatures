using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.ThrowExpressions
{
  class NullCoalesceOperator
  {
    private string name = "";
    public string Name
    {
      get => name;
      set => name = value ??
                    throw new ArgumentNullException(paramName: nameof(value), message: "Name cannot be null");
    }
  }
}
