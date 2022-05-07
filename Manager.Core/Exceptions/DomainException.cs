﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Core.Exceptions
{
    public class DomainException : Exception
    {
        internal List<string> _errors;
        public IReadOnlyCollection<string> Erros => _errors;

        public DomainException()
        {
        }

        public DomainException(string message, List<string> erros) : base(message)
        {
            _errors = erros;
        }

        public DomainException(string message) : base(message)
        {

        }

        public DomainException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
