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
            this.Items.AddRange(new List<ListItem> { 
                new ListItem{ Text="男", Value="true", Mode= ParameterMode.Raw},
                new ListItem{ Text="女", Value="false", Mode= ParameterMode.Raw}
            });
        }
    }

}
