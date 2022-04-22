using CapaDatos.Data;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class BaseContext : KryptonForm
    {

        private bool _disposed = false;
        protected Context _context { get; set; }

        public BaseContext()
        {
            _context = new Context();
           
        }
      

        protected override void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing) _context.Dispose();
            _disposed = true;
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseContext));
            this.SuspendLayout();
            // 
            // BaseContext
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseContext";
            this.Load += new System.EventHandler(this.BaseContext_Load);
            this.ResumeLayout(false);

        }

        private void BaseContext_Load(object sender, EventArgs e)
        {

        }
    }
}
