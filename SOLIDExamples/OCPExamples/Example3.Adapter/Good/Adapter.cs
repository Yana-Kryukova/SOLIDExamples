using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPExamples.Example3.Adapter.Good
{
    interface IAdapter
    {
        bool Request(string url);
    }

    class AjaxAdapter : IAdapter
    {
        public bool Request(string url)
        {
            // request and return promise
            return true;
        }
    }

    class NodeAdapter : IAdapter
    {
        public bool Request(string url)
        {
            // request and return promise
            return true;
        }
    }

    class HttpRequester
    {
        private readonly IAdapter Adapter;

        public HttpRequester(IAdapter adapter)
        {
            Adapter = adapter;
        }

        public bool Fetch(string url)
        {
            return Adapter.Request(url);
        }
    }
}
