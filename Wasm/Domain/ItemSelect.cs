using System.Collections.Generic;

using Interfaces;

namespace Domain
{
    public class ItemSelect : ISelect
    {
        public List<string> Options => new List<string>
        {
          { "Title" },
          { "Title DESC" }
        };
        public List<string> OptionsDisplay => new List<string>
        {
          { "Title" },
          { "Title DESC" }
        };
    }
}
