using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StneApiGenerator
{
    /// <summary>
    /// Makes the code generation easier.
    /// </summary>
    class CodeWriter
    {
        const int IdentSize = 4;
        private string ident = "";

        public StreamWriter Writer { get; }
        public int IdentGrade
        {
            get { return ident.Length / IdentSize; }
            set { ident = Ident(value); }
        }

        private string Ident(int grade) => new string(' ', IdentSize * grade);

        public CodeWriter(StreamWriter writer)
        {
            Writer = writer;
        }

        public void Write(string content) => Writer.Write(content);
        public void WriteLine() => Writer.WriteLine();
        public void WriteLine(string line)
        {
            Writer.WriteLine($"{ident}{line}");
        }
    }
}
