using System.Collections.Generic;

using Interfaces;

namespace Domain
{
    public class ItemSelect : ISelect
    {
        public List<string> Options => new List<string>
        {
          { "Id" },
          { "Id DESC" },
          { "Title" },
          { "Title DESC" },
          { "IsDone" },
          { "IsDone DESC" }
        };
        public List<string> OptionsDisplay => new List<string>
        {
          { "Id" },
          { "Id DESC" },
          { "Title" },
          { "Title DESC" },
          { "Check" },
          { "Check DESC" }
        };
    }
}
