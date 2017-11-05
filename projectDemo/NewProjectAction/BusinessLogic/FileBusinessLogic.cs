using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewProjectAction.BusinessLogic
{
    public class FileBusinessLogic
    {
        //tworzymy metodę -> stanowi ona logikę i odnosimy to do kontrolera 
        public bool CheckFileName(string fileName)
        {
            return fileName.Length < 20; 
        }
    }
}