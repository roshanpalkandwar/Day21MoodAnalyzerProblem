﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21MoodAnlayazer
{
    public class MoodAnalyzerCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE
        }

        public ExceptionType Type;

        public MoodAnalyzerCustomException(ExceptionType type, string message) : base(message)
        {
            Type = type;
        }
    }
}
