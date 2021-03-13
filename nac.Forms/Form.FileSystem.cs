﻿using System;

namespace nac.Forms
{
    public partial class Form
    {
        public class FilePathFor_Functions
        {
            public Action<string> updateFileName { get; set; }
        }
        
        public Form FilePathFor(string fieldName, 
            string fileFilter = null,
            string initialFileName = null,
            bool fileMustExist = true,
            Action<string> onFilePathChanged = null,
            FilePathFor_Functions functions = null
        )
        {
            // initialize the filename in the model
            this.Model[fieldName] = "";

            var filePicker = new controls.FilePicker();
            
            this.AddRowToHost(filePicker);
            return this;
        }
        
        
    }
}