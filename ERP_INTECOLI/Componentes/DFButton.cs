using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace ERP_INTECOLI.Componentes
{
    public partial class DFButton : Component
    {
        int borderSize = 0;
        int borderRaius = 40;

        Color borderColor = Color.PaleVioletRed;
        [Category("DF Code Advance")]

        public int BorderSize 
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                //this.Invalidate();
            }
        
        }

        public DFButton()
        {
            InitializeComponent();
        }

        public DFButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
