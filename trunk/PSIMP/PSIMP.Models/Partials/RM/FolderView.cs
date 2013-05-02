using Ext.Net.MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    [Proxy(Read = "~/Resource/FolderView")]
    [JsonReader(Root = "data")]
    public class FolderView
    {
        public FolderView(bool isFolder)
        {
            IsFolder = isFolder;
        }
        public long ID { get; set; }
        public string Name { get; set; }
        public bool IsFolder { get; set; }
        public bool CanDelete { get; set; }
        public string FileType { get; set; }
        public string FileSize { get; set; }
        public bool IsShared { get; set; }
        public string Remark { get; set; }
        public string SharedRemark { get; set; }
    }
}
