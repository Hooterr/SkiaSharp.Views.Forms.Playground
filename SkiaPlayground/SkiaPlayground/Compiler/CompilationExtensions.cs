using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkiaPlayground.Compiler
{
    public static class CompilationExtensions
    {
        public static CompilationMessageSeverity ToCompilationMessageSeverity(this DiagnosticSeverity severity)
        {
            switch (severity)
            {
                case DiagnosticSeverity.Info:
                    return CompilationMessageSeverity.Information;
                case DiagnosticSeverity.Warning:
                    return CompilationMessageSeverity.Warning;
                case DiagnosticSeverity.Error:
                    return CompilationMessageSeverity.Error;
                default:
                    return CompilationMessageSeverity.None;
            }
        }
    }
}
