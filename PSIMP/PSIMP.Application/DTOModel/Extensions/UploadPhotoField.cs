using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSIMP.Application.DTOModel.Extensions
{
    public class UploadPhotoField:FieldContainer
    {
        public UploadPhotoField()
        {
            this.Items.Add(new FileUploadField
            {
                 ButtonText="浏览"
            });
            this.Items.Add(new Image { 
                 
            });
        }
    }
}
