﻿using System;
using System.IO;

namespace ORPZ_lab4.Decorator
{
    public class FileWriter : BaseFileWriter
    {
        public FileWriter(string data) : base(data)
        {
        }

        public override void DoTransformation()
        {
            
        }
    }
}