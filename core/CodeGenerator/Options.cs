﻿using System.Collections.Generic;
using CommandLine;

namespace CodeGen
{
    internal class Options
    {
        [Option('p', "path", HelpText = "Base path for processing sources, references and target.")]
        public string Path { get; set; }

        [Option('s', "source", Separator = ';', HelpText = "Input source files.")]
        public IEnumerable<string> Sources { get; set; }

        [Option('r', "reference", Separator = ';', HelpText = "Input reference files for building sources.")]
        public IEnumerable<string> References { get; set; }

        [Option('d', "define", HelpText = "Defines name as a symbol which is used in compiling.")]
        public IEnumerable<string> Defines { get; set; }

        [Option('t', "target", HelpText = "Filename of a generated code.")]
        public string TargetFile { get; set; }

        [Option('c', "protobuf", Default = true, HelpText = "Use protobuf-net for serializing generated message type.")]
        public bool UseProtobuf { get; set; }

        [Option("serverentity", HelpText = "Name of server entity base class")]
        public string ServerEntity { get; set; }

        [Option("cliententity", HelpText = "Name of client entity base class")]
        public string ClientEntity { get; set; }
    }
}
