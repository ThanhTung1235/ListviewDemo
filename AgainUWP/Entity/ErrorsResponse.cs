using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainUWP.Entity
{
    class ErrorsResponse
    {
        private int _status;
        private string _message;
        private Dictionary<string, string> _errors;

        public int status { get => _status; set => _status = value; }
        public string message { get => _message; set => _message = value; }
        public Dictionary<string, string> error { get => _errors; set => _errors = value; }
    }
}
