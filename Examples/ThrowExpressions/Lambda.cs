using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.ThrowExpressions
{
  class Lambda
  {
    DateTime ToDateTime(IFormatProvider provider) =>
      throw new InvalidCastException("Conversion to a DateTime is not supported.");
  }
}
