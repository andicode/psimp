using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSIMP.Models.Extensions
{
    public class SexComboBox:ComboBox
    {
        public SexComboBox()
        {
            this.ItemsFromEnum = typeof(Enums.Sex);
        }
    }
}
