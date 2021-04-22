using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wox.Plugin.Translator
{
    class Main : IPlugin
    {
        public List<Result> Query(Query query)
        {
            var result = new Result
            {
                Title = "Hello World from Auto-Translator!",
                SubTitle = $"Query: {query.Search}",
                IcoPath = Path.Combine("Images", "translate.png")
            };
            return new List<Result> { result };
        }

        public void Init(PluginInitContext context)
        {

        }
    }
}
