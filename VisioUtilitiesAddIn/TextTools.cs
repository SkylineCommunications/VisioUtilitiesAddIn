using Microsoft.Office.Tools.Ribbon;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TestVisioAddIn;

namespace VisioUtilitiesAddIn
{
    public partial class TextTools
    {
        private void TextTools_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void replaceButton_Click(object sender, RibbonControlEventArgs e)
        {
            var form = new ReplaceText();
            form.Show();
        }
    }
}
