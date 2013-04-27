using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newsblur
{
    public class CodeResult
    {
        public int code { get; set; }
        public Dictionary<string, string> errors { get; set; }
    }
}
