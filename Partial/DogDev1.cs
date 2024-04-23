using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial;

internal partial class Dog
{
    private int _distance;
    public int Distance => _distance;
    public void Walk() => _distance++;
}
